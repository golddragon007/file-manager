using System;
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

        // Constructor, create automaticalli a connection to the definied db.
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
                // Table name: field names
                // files: id, title, author, year, doi, favorite, vdirs_id, type, note, location, added, rread
                // file_tag: files_id, tags_id
                // tags: id, name
                // vdirs: id, name, parentdir_id
                // settings: id, name, value
                // Use http://sqlitebrowser.org/ program to watch how it looks like the db strukture.

                SQLiteCommand sqlc = new SQLiteCommand("CREATE TABLE 'files' ('id' INTEGER PRIMARY KEY  AUTOINCREMENT  NOT NULL  UNIQUE, 'title' VARCHAR NOT NULL, 'author' VARCHAR NULL DEFAULT NULL, 'year' INTEGER NULL DEFAULT NULL, 'DOI' VARCHAR NULL DEFAULT NULL, 'vdirs_id' INTEGER NULL DEFAULT NULL REFERENCES vdirs(id) ON UPDATE RESTRICT ON DELETE RESTRICT, 'favorite' BOOL DEFAULT 0, 'type' VARCHAR NOT NULL, 'note' VARCHAR NULL DEFAULT NULL, 'location' VARCHAR NOT NULL, 'added' VARCHAR DEFAULT CURRENT_TIMESTAMP, 'rread' VARCHAR NULL DEFAULT NULL)", dbConnection);
                sqlc.ExecuteNonQuery();
                sqlc = new SQLiteCommand("CREATE TABLE 'tags' ('id' INTEGER PRIMARY KEY  AUTOINCREMENT  NOT NULL  UNIQUE, 'name' VARCHAR NOT NULL)", dbConnection);
                sqlc.ExecuteNonQuery();
                sqlc = new SQLiteCommand("CREATE TABLE 'file_tag' ('id' INTEGER PRIMARY KEY  AUTOINCREMENT  NOT NULL  UNIQUE, 'files_id' INTEGER NOT NULL REFERENCES files(id) ON UPDATE RESTRICT ON DELETE RESTRICT, 'tags_id' INTEGER NOT NULL REFERENCES tags(id) ON UPDATE RESTRICT ON DELETE RESTRICT)", dbConnection);
                sqlc.ExecuteNonQuery();
                sqlc = new SQLiteCommand("CREATE TABLE 'vdirs' ('id' INTEGER PRIMARY KEY  AUTOINCREMENT NOT NULL  UNIQUE, 'name' VARCHAR NOT NULL, 'parentdir_id' INTEGER NULL DEFAULT NULL REFERENCES vdirs(id) ON UPDATE RESTRICT ON DELETE RESTRICT)", dbConnection);
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

            SQLiteCommand sqlc = new SQLiteCommand(@"SELECT f.*, group_concat(t.name, ', ') AS tags_name FROM files f
	                LEFT JOIN file_tag ft ON ft.'files_id' = f.'id'
	                LEFT JOIN tags t ON ft.'tags_id' = t.'id'
	                GROUP BY f.title", dbConnection);
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
                    Convert.ToString(sqldr["tags_name"]),
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

            SQLiteCommand sqlc = new SQLiteCommand(@"SELECT f.*, group_concat(t.name, ', ') AS tags_name FROM files f
	                LEFT JOIN file_tag ft ON ft.'files_id' = f.'id'
	                LEFT JOIN tags t ON ft.'tags_id' = t.'id'
                    WHERE f.added >= $added
	                GROUP BY f.title", dbConnection);
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
                    Convert.ToString(sqldr["tags_name"]),
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

            SQLiteCommand sqlc = new SQLiteCommand(@"SELECT f.*, group_concat(t.name, ', ') AS tags_name FROM files f
	                LEFT JOIN file_tag ft ON ft.'files_id' = f.'id'
	                LEFT JOIN tags t ON ft.'tags_id' = t.'id'
                    WHERE f.rread >= $rread
	                GROUP BY f.title", dbConnection);
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
                    Convert.ToString(sqldr["tags_name"]),
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

            SQLiteCommand sqlc = new SQLiteCommand(@"SELECT f.*, group_concat(t.name, ', ') AS tags_name FROM files f
	                LEFT JOIN file_tag ft ON ft.'files_id' = f.'id'
	                LEFT JOIN tags t ON ft.'tags_id' = t.'id'
                    WHERE f.favorite = 1
	                GROUP BY f.title", dbConnection);
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
                    Convert.ToString(sqldr["tags_name"]),
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

        // Search a string everywhere except virtual dirs string.
        public List<Files> simpleSearch(string searchedString)
        {
            List<Files> files = new List<Files>();

            SQLiteCommand sqlc = new SQLiteCommand(@"SELECT f.*, group_concat(t.name, ', ') AS tags_name FROM files f 
	                LEFT JOIN file_tag ft ON ft.'files_id' = f.'id'
	                LEFT JOIN tags t ON ft.'tags_id' = t.'id'
	                WHERE f.'title' LIKE $searchString OR 
	                f.'author' LIKE $searchString OR 
	                f.'year' LIKE $searchString OR 
	                f.'doi' LIKE $searchString OR 
	                f.'favorite' LIKE $searchString OR
	                f.'vdirs_id' LIKE $searchString OR 
	                f.'type' LIKE $searchString OR 
	                f.'note' LIKE $searchString OR 
	                f.'location' LIKE $searchString OR 
	                f.'added' LIKE $searchString OR 
	                f.'rread' LIKE $searchString OR
	                t.'name' LIKE $searchString
	                GROUP BY f.title", dbConnection);
            sqlc.Parameters.AddWithValue("$searchString", "%" + searchedString + "%");
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
                    Convert.ToString(sqldr["tags_name"]),
                    Convert.ToString(sqldr["note"]),
                    Convert.ToString(sqldr["location"]),
                    Convert.ToString(sqldr["added"]),
                    Convert.ToString(sqldr["rread"])
                    ));
            }

            return files;
        }

        // Set receantly read parameter.
        public void setReceantlyReadNow(int id)
        {
            // Actual date.
            DateTime dt = DateTime.Now;

            List<Files> files = new List<Files>();

            SQLiteCommand sqlc = new SQLiteCommand(@"UPDATE files SET rread = $rread WHERE id = $id", dbConnection);
            sqlc.Parameters.AddWithValue("$rread", dt.ToString("yyyy-MM-dd HH:mm:ss"));
            sqlc.Parameters.AddWithValue("$id", id);
            sqlc.ExecuteNonQuery();
        }

        // Returns a VDir tree from the db.
        public VDirs getVDirs()
        {
            VDirs returnVdir = new VDirs(-1, "root");

            SQLiteCommand sqlc = new SQLiteCommand("SELECT * FROM vdirs WHERE parentdir_id IS NULL", dbConnection);
            SQLiteDataReader sqldr = sqlc.ExecuteReader();
            while (sqldr.Read())
            {
                returnVdir.addNewChild(getVDirsById(Convert.ToInt32(sqldr["id"])));
            }

            return returnVdir;
        }

        // Get VDirs by main ID.
        public VDirs getVDirsById(int id)
        {
            VDirs returnVdir = null;

            if (id > 0)
            {
                List<VDirs> tmpVdirs = new List<VDirs>();
                int firstId = -2;

                SQLiteCommand sqlc = new SQLiteCommand(@"WITH vdirsCTE AS (
                        SELECT *,0 AS steps
                        FROM vdirs
                        WHERE id = $id
    
                        UNION ALL
  
                        SELECT mgr.*, usr.steps + 1 AS steps
                        FROM vdirsCTE AS usr
                        INNER JOIN vdirs AS mgr
                            ON usr.id = mgr.parentdir_id
                    )
                    SELECT * FROM vdirsCTE AS u;", dbConnection);
                sqlc.Parameters.AddWithValue("$id", id);
                SQLiteDataReader sqldr = sqlc.ExecuteReader();
                while (sqldr.Read())
                {
                    tmpVdirs.Add(new VDirs(
                                Convert.ToInt32(sqldr["id"]),
                                Convert.ToString(sqldr["name"]),
                                (sqldr["parentdir_id"] == System.DBNull.Value ? -1 : Convert.ToInt32(sqldr["parentdir_id"]))
                            ));
                    if (firstId == -2)
	                {
                        firstId = (sqldr["parentdir_id"] == System.DBNull.Value ? -1 : Convert.ToInt32(sqldr["parentdir_id"]));
	                }
                }

                List<int> idEnd = new List<int>();
                sqlc = new SQLiteCommand(@"SELECT a.* FROM vdirs a WHERE not EXISTS(SELECT 1 FROM vdirs b WHERE a.id=b.parentdir_id)", dbConnection);
                sqldr = sqlc.ExecuteReader();
                while (sqldr.Read())
                {
                    idEnd.Add(Convert.ToInt32(sqldr["id"]));
                }

                returnVdir = recursiveBuildVDirs(ref tmpVdirs, ref idEnd, firstId);
            }
                
            return returnVdir;
        }

        // Generate tree object in recursive mode.
        private VDirs recursiveBuildVDirs(ref List<VDirs> treeList, ref List<int> idEnd, int actualId)
        {
            int index = idEnd.FindIndex(a => a == actualId);
            if (treeList.Count == 0 || index > 0)
            {
                return null;
            }
            else
            {
                VDirs tmp = null;
                VDirs tmp2 = null;

                foreach (VDirs item in treeList)
                {
                    if (item.ParentId == actualId)
                    {
                        tmp = new VDirs(item.Id, item.Name, item.ParentId);
                        tmp2 = item;
                        break;
                    }
                }

                if (tmp2 != null)
                {
                    treeList.Remove(tmp2);
                }

                if (tmp != null)
                {
                    VDirs tmp3 = null;
                    do
                    {
                        tmp3 = recursiveBuildVDirs(ref treeList, ref idEnd, tmp.Id);
                        if (tmp3 != null)
                        {
                            tmp.addNewChild(tmp3);
                        }
                    } while (tmp3 != null);
                }

                return tmp;
            }
        }

        // Add new vdir the the selected place.
        public void addVdirs(int mainID, string newDirName)
        {
            SQLiteCommand sqlc = new SQLiteCommand(@"INSERT INTO vdirs (name, parentdir_id) VALUES ($name, $parentdir_id)", dbConnection);
            sqlc.Parameters.AddWithValue("$name", newDirName);
            sqlc.Parameters.AddWithValue("$parentdir_id", (mainID == -1 ? null : mainID.ToString()));
            sqlc.ExecuteNonQuery();
        }

        // Moves a vdir into another.
        public void moveVdirs(int whichId, int newSubId)
        {
            SQLiteCommand sqlc = new SQLiteCommand(@"UPDATE vdirs SET parentdir_id = $parentdir_id WHERE id = $id", dbConnection);
            sqlc.Parameters.AddWithValue("$id", whichId);
            sqlc.Parameters.AddWithValue("$parentdir_id", (newSubId == -1 ? null : newSubId.ToString()));
            sqlc.ExecuteNonQuery();
        }

        // Remove selected vdir and his all child.
        public void removeVdirs(int removeableId)
        {
            using (var transaction = dbConnection.BeginTransaction())
            {
                SQLiteCommand sqlc = new SQLiteCommand(@"WITH vdirsCTE AS (
                        SELECT *,0 AS steps
                        FROM vdirs
                        WHERE id = $id
    
                        UNION ALL
  
                        SELECT mgr.*, usr.steps + 1 AS steps
                        FROM vdirsCTE AS usr
                        INNER JOIN vdirs AS mgr
                            ON usr.id = mgr.parentdir_id
                    )
                    SELECT * FROM vdirsCTE AS u ORDER BY steps DESC;", dbConnection);
                sqlc.Parameters.AddWithValue("$id", removeableId);
                SQLiteDataReader sqldr = sqlc.ExecuteReader();
                using (var cmd = dbConnection.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM vdirs WHERE id = $id;";

                    while(sqldr.Read())
                    {
                        cmd.Parameters.AddWithValue("$id", Convert.ToString(sqldr["id"]));
                        cmd.ExecuteNonQuery();
                    }
                }
                transaction.Commit();
            }
        }

        // Removes all vdirs.
        public void removeAllVdirs()
        {
            SQLiteCommand sqlc = new SQLiteCommand(@"DELETE FROM vdirs;", dbConnection);
            sqlc.ExecuteNonQuery();
        }

        // Set file to favorite or not.
        public void toggleToFavorite(int id, bool isFavorite)
        {
            SQLiteCommand sqlc = new SQLiteCommand(@"UPDATE files SET favorite = $favorite WHERE id = $id", dbConnection);
            sqlc.Parameters.AddWithValue("$id", id);
            sqlc.Parameters.AddWithValue("$favorite", isFavorite);
            sqlc.ExecuteNonQuery();
        }
    }
}
