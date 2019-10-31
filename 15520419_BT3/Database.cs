using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace BT3_15520419
{
    public class Database
    {
        string Folder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

        public Database()
        {
            CreateDatabase();
        }

        public bool CreateDatabase()
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(Folder, "flower_manager.db")))
                {
                    connection.CreateTable<FlowerType>();
                    connection.CreateTable<Flower>();
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                return false;
            }
        }

        public bool InsertFlowerType(FlowerType type)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(Folder, "flower_manager.db")))
                {
                    connection.Insert(type);
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                return false;
            }
        }

        public bool UpdateFlowerType(FlowerType type)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(Folder, "flower_manager.db")))
                {
                    connection.Update(type);
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                return false;
            }
        }

        public bool DeleteFlowerType(FlowerType type)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(Folder, "flower_manager.db")))
                {
                    connection.Delete(type);
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                return false;
            }
        }

        public List<FlowerType> SelectFlowerType()
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(Folder, "flower_manager.db")))
                {
                    return connection.Table<FlowerType>().ToList();
                }
            }
            catch (SQLiteException ex)
            {
                return null;
            }
        }

        public FlowerType SelectFlowerTypeById(int id)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(Folder, "flower_manager.db")))
                {
                    return connection.Table<FlowerType>().Where(fl => fl.Id == id).FirstOrDefault();
                }
            }
            catch (SQLiteException ex)
            {
                return null;
            }
        }

        public bool InsertFlower(Flower flower)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(Folder, "flower_manager.db")))
                {
                    connection.Insert(flower);
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                return false;
            }
        }

        public List<Flower> SelectFlowerByType(int typeId)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(Folder, "flower_manager.db")))
                {
                    return connection.Table<Flower>().Where(fl => fl.TypeId == typeId).ToList();
                }
            }
            catch (SQLiteException ex)
            {
                return null;
            }
        }
    }
}
