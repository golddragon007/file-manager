﻿using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    // SQLite documentation: http://www.sqlite.org .
    class dbManager
    {
        private string dbName;
        private SQLiteConnection dbConnection;

        public dbManager(string dbName)
        {
            this.dbName = dbName;

            bool dbExisted = true;
            if (!File.Exists(dbName))
            {
                SQLiteConnection.CreateFile(dbName);
                dbExisted = false;
            }

            dbConnection = new SQLiteConnection("Data Source=" + dbName + ";Version=3;foreign keys=true;");
            dbConnection.Open();

            if (!dbExisted)
            {
                // Table name: fieldnames
                // files: id, title, author, year, doi, favorite, vdirs_id, type, note, location, added, rread
                // file_tag: files_id, tags_id
                // tags: id, name
                // vdirs: id, name, subdir_id
                // settings: id, name, value
                // Use http://sqlitebrowser.org/ program to watch how it looks like the db.

                SQLiteCommand sqlc = new SQLiteCommand("CREATE TABLE 'files' ('id' INTEGER PRIMARY KEY  AUTOINCREMENT  NOT NULL  UNIQUE, 'title' VARCHAR NOT NULL, 'author' VARCHAR NULL DEFAULT NULL, 'year' INTEGER NULL DEFAULT NULL, 'DOI' VARCHAR NULL DEFAULT NULL, 'vdirs_id' INTEGER NULL DEFAULT NULL REFERENCES vdirs(id) ON UPDATE RESTRICT ON DELETE RESTRICT, 'favorite' BOOL DEFAULT 0, 'type' VARCHAR NOT NULL, 'note' VARCHAR NULL DEFAULT NULL, 'location' VARCHAR NOT NULL, 'added' VARCHAR DEFAULT CURRENT_TIMESTAMP, 'rread' VARCHAR NULL DEFAULT NULL)", dbConnection);
                sqlc.ExecuteNonQuery();
                sqlc = new SQLiteCommand("CREATE TABLE 'tags' ('id' INTEGER PRIMARY KEY  AUTOINCREMENT  NOT NULL  UNIQUE, 'name' VARCHAR NOT NULL)", dbConnection);
                sqlc.ExecuteNonQuery();
                sqlc = new SQLiteCommand("CREATE TABLE 'file_tag' ('id' INTEGER PRIMARY KEY  AUTOINCREMENT  NOT NULL  UNIQUE, 'files_id' INTEGER NOT NULL REFERENCES files(id) ON UPDATE RESTRICT ON DELETE RESTRICT, 'tags_id' INTEGER NOT NULL REFERENCES tags(id) ON UPDATE RESTRICT ON DELETE RESTRICT)", dbConnection);
                sqlc.ExecuteNonQuery();
                sqlc = new SQLiteCommand("CREATE TABLE 'vdirs' ('id' INTEGER PRIMARY KEY  AUTOINCREMENT NOT NULL  UNIQUE, 'name' VARCHAR NOT NULL, 'subdir_id' INTEGER NULL DEFAULT NULL REFERENCES vdirs(id) ON UPDATE RESTRICT ON DELETE RESTRICT)", dbConnection);
                sqlc.ExecuteNonQuery();
                sqlc = new SQLiteCommand("CREATE TABLE 'settings' ('id' INTEGER PRIMARY KEY  AUTOINCREMENT NOT NULL  UNIQUE, 'name' VARCHAR NOT NULL, 'value' VARCHAR NOT NULL)", dbConnection);
                sqlc.ExecuteNonQuery();
                sqlc = new SQLiteCommand("INSERT INTO settings ('id', 'name', 'value') VALUES (1, $name, $value)", dbConnection);
                sqlc.Parameters.AddWithValue("$name", "Allowed extensions");
                sqlc.Parameters.AddWithValue("$value", "doc,docx,xls,xlsx,pdf,txt,htm,html");
                sqlc.ExecuteNonQuery();
            }
        }

        // Close db conn. use when you exit from the app. (todo)
        public void closeDbConn()
        {
            dbConnection.Close();
        }

        // Open db conn.
        public void openDbConn()
        {
            dbConnection.Open();
        }

        // Returns a list with all Files record.
        public List<Files> getAllFiles()
        {
            List<Files> files = new List<Files>();

            SQLiteCommand sqlc = new SQLiteCommand("SELECT * FROM files", dbConnection);
            SQLiteDataReader sqldr = sqlc.ExecuteReader();
            while (sqldr.Read())
            {
                // Do not use sqldr["id"].toString() because it won't work and kill the program!
                files.Add(new Files(
                    Convert.ToInt32(sqldr["id"]),
                    Convert.ToString(sqldr["title"]),
                    Convert.ToString(sqldr["author"]),
                    Convert.ToString(sqldr["year"]),
                    Convert.ToString(sqldr["doi"]),
                    Convert.ToString(sqldr["vdirs_id"]),
                    Convert.ToBoolean(sqldr["favorite"]),
                    Convert.ToString(sqldr["type"]),
                    Convert.ToString(sqldr["note"]),
                    Convert.ToString(sqldr["location"]),
                    Convert.ToString(sqldr["added"]),
                    Convert.ToString(sqldr["rread"])
                    ));
            }

            return files;
        }

        // Returns a list with all receantly added Files record (past 3 days).
        public List<Files> getAllFilesReceantlyAdded()
        {
            // Date -3 days ago.
            DateTime dt = DateTime.Now.AddDays(-3d);

            List<Files> files = new List<Files>();

            SQLiteCommand sqlc = new SQLiteCommand("SELECT * FROM files WHERE added >= $added", dbConnection);
            sqlc.Parameters.AddWithValue("$added", dt.ToString("yyyy-MM-dd HH:mm:ss"));
            SQLiteDataReader sqldr = sqlc.ExecuteReader();
            while (sqldr.Read())
            {
                // Do not use sqldr["id"].toString() because it won't work and kill the program!
                files.Add(new Files(
                    Convert.ToInt32(sqldr["id"]),
                    Convert.ToString(sqldr["title"]),
                    Convert.ToString(sqldr["author"]),
                    Convert.ToString(sqldr["year"]),
                    Convert.ToString(sqldr["doi"]),
                    Convert.ToString(sqldr["vdirs_id"]),
                    Convert.ToBoolean(sqldr["favorite"]),
                    Convert.ToString(sqldr["type"]),
                    Convert.ToString(sqldr["note"]),
                    Convert.ToString(sqldr["location"]),
                    Convert.ToString(sqldr["added"]),
                    Convert.ToString(sqldr["rread"])
                    ));
            }

            return files;
        }

        // Returns a list with all receantly read Files record (past 3 days).
        public List<Files> getAllFilesReceantlyRead()
        {
            // Date -3 days ago.
            DateTime dt = DateTime.Now.AddDays(-3d);

            List<Files> files = new List<Files>();

            SQLiteCommand sqlc = new SQLiteCommand("SELECT * FROM files WHERE rread >= $rread", dbConnection);
            sqlc.Parameters.AddWithValue("$rread", dt.ToString("yyyy-MM-dd HH:mm:ss"));
            SQLiteDataReader sqldr = sqlc.ExecuteReader();
            while (sqldr.Read())
            {
                // Do not use sqldr["id"].toString() because it won't work and kill the program!
                files.Add(new Files(
                    Convert.ToInt32(sqldr["id"]),
                    Convert.ToString(sqldr["title"]),
                    Convert.ToString(sqldr["author"]),
                    Convert.ToString(sqldr["year"]),
                    Convert.ToString(sqldr["doi"]),
                    Convert.ToString(sqldr["vdirs_id"]),
                    Convert.ToBoolean(sqldr["favorite"]),
                    Convert.ToString(sqldr["type"]),
                    Convert.ToString(sqldr["note"]),
                    Convert.ToString(sqldr["location"]),
                    Convert.ToString(sqldr["added"]),
                    Convert.ToString(sqldr["rread"])
                    ));
            }

            return files;
        }

        // Returns a list with all favorite Files record (past 3 days).
        public List<Files> getAllFilesFavorite()
        {
            List<Files> files = new List<Files>();

            SQLiteCommand sqlc = new SQLiteCommand("SELECT * FROM files WHERE favorite = 1", dbConnection);
            SQLiteDataReader sqldr = sqlc.ExecuteReader();
            while (sqldr.Read())
            {
                // Do not use sqldr["id"].toString() because it won't work and kill the program!
                files.Add(new Files(
                    Convert.ToInt32(sqldr["id"]),
                    Convert.ToString(sqldr["title"]),
                    Convert.ToString(sqldr["author"]),
                    Convert.ToString(sqldr["year"]),
                    Convert.ToString(sqldr["doi"]),
                    Convert.ToString(sqldr["vdirs_id"]),
                    Convert.ToBoolean(sqldr["favorite"]),
                    Convert.ToString(sqldr["type"]),
                    Convert.ToString(sqldr["note"]),
                    Convert.ToString(sqldr["location"]),
                    Convert.ToString(sqldr["added"]),
                    Convert.ToString(sqldr["rread"])
                    ));
            }

            return files;
        }

        // Get allowed file extensions.
        public string getFileExtensions()
        {
            SQLiteCommand sqlc = new SQLiteCommand("SELECT * FROM settings WHERE id = 1", dbConnection);
            SQLiteDataReader sqldr = sqlc.ExecuteReader();
            sqldr.Read();

            return Convert.ToString(sqldr["value"]);
        }

        // Add multiple files.
        public void addFiles(string[] filePaths)
        {
            using (var transaction = dbConnection.BeginTransaction())
            {
                using (var cmd = dbConnection.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO files (id, title, author, year, doi, favorite, type, note, location, rread) VALUES (NULL, $title, NULL, NULL, NULL, 0, $type, NULL, $location, NULL);";

                    foreach (var filePath in filePaths)
                    {
                        cmd.Parameters.AddWithValue("$title", Path.GetFileNameWithoutExtension(filePath));
                        cmd.Parameters.AddWithValue("$type", Path.GetExtension(filePath));
                        cmd.Parameters.AddWithValue("$location", filePath);
                        cmd.ExecuteNonQuery();
                    }
                }
                transaction.Commit();
            }
        }

        // Delete only one File.
        public void removeFiles(string id)
        {
            if (!id.Equals(""))
            {
                SQLiteCommand sqlc = new SQLiteCommand("DELETE FROM files WHERE id = $id;", dbConnection);
                sqlc.Parameters.AddWithValue("$id", id);
                sqlc.ExecuteNonQuery();
            }
        }

        // Delete multiple File.
        public void removeFiles(string[] ids)
        {
            if (ids.Length != 0)
            {
                using (var transaction = dbConnection.BeginTransaction())
                {
                    using (var cmd = dbConnection.CreateCommand())
                    {
                        cmd.CommandText = "DELETE FROM files WHERE id = $id;";

                        foreach (string id in ids)
                        {
                            cmd.Parameters.AddWithValue("$id", id);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    transaction.Commit();
                }
            }
        }
    }
}