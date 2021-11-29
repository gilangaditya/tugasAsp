using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Absensi.Models
{
    public class ProsesMahasiswa
    {
        koneksiDB db=null;
        public ProsesMahasiswa(){
            db=new koneksiDB();
        }
        public List<DataMahasiswa> getMahasiswa(){
            List<DataMahasiswa> mhs=new List<DataMahasiswa>();
            using(MySqlConnection connection=db.openConnection())
            {
                string query="Select * from tbl_mhs";
                using(MySqlCommand cmd=new MySqlCommand(query)){
                    cmd.Connection=connection;
                    connection.Open();
                    using(MySqlDataReader sdr=cmd.ExecuteReader())
                    {
                        while(sdr.Read())
                        {
                            mhs.Add(new DataMahasiswa
                            {
                                Id=Convert.ToInt32(sdr["id"]),
                                Nim=sdr["nim"].ToString(),
                                Nama=sdr["nama"].ToString(),
                                Kelas=sdr["kelas"].ToString(),
                                Jurusan=sdr["jurusan"].ToString()

                            });
                        }
                    }
                    connection.Close();
                }
                
            }
            return mhs;
        }
        
        public bool saveMahasiswa(DataMahasiswa mahasiswa){
            bool hasil=false;
            using (MySqlConnection connection=db.openConnection())
            {
                using(MySqlCommand command=new MySqlCommand())
                {
                    command.Connection=connection;
                    connection.Open();
                    command.CommandText="insert into tbl_mhs(nim,nama,kelas,jurusan)"+
                                        "values(@Nim,@Nama,@Kelas,@Jurusan)";
                    command.Parameters.Add("Nim",MySqlDbType.VarChar).Value=mahasiswa.Nim;
                    command.Parameters.Add("Nama",MySqlDbType.VarChar).Value=mahasiswa.Nama;
                    command.Parameters.Add("Kelas",MySqlDbType.VarChar).Value=mahasiswa.Kelas;
                    command.Parameters.Add("jurusan",MySqlDbType.VarChar).Value=mahasiswa.Jurusan;
                    command.ExecuteNonQuery();
                    connection.Close();
                    hasil=true;
                }
            }
            return hasil;
        }
    }

}