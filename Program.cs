﻿using System;

namespace Project_Assessment_3
{
    class Program
    {
        struct Mahasiswa
		{
			public string Kelamin;
			public string Nama;
			public int Id;
            
		}        
		
        static Mahasiswa[] MyGlobal = new Mahasiswa[10]; //variabel array gelobal
        
        int input; //mengecheck jumlah length variabel array gelobal
        
        
        

//  --------------------------------------- Awal Main Program -----------------------------------------------
        
        public static void Main(string[] args)
        {
            
			Program p = new Program();
			
			int masukan;
			// string pilih;
                
                menu : //goto balik ke menu utama
                Console.Clear();
                Console.WriteLine("      ||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
                Console.WriteLine("      |               	PROGRAM DAFTAR ABSEN MAHASISWA                       |");
                Console.WriteLine("      |                    	KELAS D4SM-44-03                             |");
                Console.WriteLine("      |           KELOMPOK :	1. MUHAMMAD TAUFIQ SHIDIQ                    |");
                Console.WriteLine("      |              		2. muhammad Ainur Rafiq                      |");
                Console.WriteLine("      |              		3. Muhammad Gilang Radhitya Permana          |");
                Console.WriteLine("      |              			                                     |");
                Console.WriteLine("      |              Ketikan Angk Untuk Memilih Salah 1 Menu                 |");
                Console.WriteLine("      |_____________________________________________________________________ |");
                Console.WriteLine("      | 1. Menambahkan Data Mahasiswa                 	                     |");
                Console.WriteLine("      | 2. Menampilkan Data Mahasiswa      				     |");
                Console.WriteLine("      | 3. Mencari Data Mahasiswa      				             |");
                Console.WriteLine("      | 4. Menghapus Data Mahasiswa     			             |");
                Console.WriteLine("      |>>>>>>>>>>>>>>>>>>>>>>>  0. Exit or Back  <<<<<<<<<<<<<<<<<<<<<<<<<<<<|");
            try {
			Console.Write("\nInsert Number Of Menu : ");
			masukan = Convert.ToInt32(Console.ReadLine());
			
			switch(masukan)
				{
					case 1:
						p.Tambah_Mahasiswa();
						goto menu;
						
					case 2:
						p.Tampil_Mahasiswa();
						goto menu;
						
					case 3:
						p.Cari_Mahasiswa();
						goto menu;
						
					case 4:
						p.Hapus_Mahasiswa();
						goto menu;
						
					case 0:
					Benerin:

						Console.Write("are you sure want to quit? -> yes or no : ");
						String jawaban = Console.ReadLine();

						switch(jawaban){
							case "yes" :
								Console.WriteLine("-------------------------****-------------------------");
								Console.WriteLine("");
								Console.WriteLine("************DO YOUR BEST AND THANK YOU***************");
								Console.WriteLine("");
								Console.WriteLine("-------------------------****-------------------------");
								Console.WriteLine("");
								break;
							case "no" :
								goto menu;
							default :
								Console.WriteLine("");
								Console.WriteLine("please choose 'yes' or 'no'");
								Console.WriteLine("");
								Console.WriteLine("-------------****---------------");
								Console.WriteLine("");
								goto Benerin;
						}

						Console.WriteLine("\nPress Any Key To Exit");
						Console.ReadKey();
						break;
								
					default:
						if (masukan < 0 || masukan > 4){
							Console.WriteLine("you just entered {0} which is a wrong value", masukan);
						}

						Console.WriteLine("\nPress Any Key To Exit");
						Console.ReadKey();
						goto menu;

				} // -> akhir switch
					
			}catch (Exception e) {
				Console.WriteLine(e.Message);
				Console.WriteLine("you have to write a string data type");
				Console.WriteLine("\nPress Any Key To Select Other Menu");
						Console.ReadKey();
						goto menu;
			}
        } // -> akhir main program

//  --------------------------------------- Akhir Main Program -----------------------------------------------



//  --------------------------------------- awal function tambah anggota -------------------------------------

        public void Tambah_Mahasiswa(){

            Console.Write("Berapa jumlah anggota yang akan anda input : ");
            int j = Convert.ToInt32(Console.ReadLine());
            
            input += j;
            
            for(int i = 0 ; i <  j;  i++){
				
                Console.WriteLine("-------------------------------------------");
				Console.Write("no absen anggota ke : " );
                MyGlobal[i].Id = Convert.ToInt16(Console.ReadLine());
                Console.Write("Nama Anggota : ");
                MyGlobal[i].Nama = Console.ReadLine();
                Console.Write("Jenis Kelamin : " );
                MyGlobal[i].Kelamin = Console.ReadLine();
                Console.WriteLine("-------------------------------------------");

         	} //akhir mother for

            Console.WriteLine("\nPress Any Key To Select Other Menu");
            Console.ReadKey();
            
        }
        
//  --------------------------------------- akhir function tambah anggota -------------------------------------



//  --------------------------------------- awal function menampilkan anggota --------------------------------- 

        public void Tampil_Mahasiswa(){

			for(int i = 0; i < input; i++){
				Console.WriteLine("-------------------------------------------");
				Console.WriteLine(" Nomor absen mahasiswa ke : " + MyGlobal[i].Id);
				Console.WriteLine(" Namaa anggota : " + MyGlobal[i].Nama);
				Console.WriteLine(" Jenis Kelamin : " + MyGlobal[i].Kelamin);
				Console.WriteLine("-------------------------------------------");
				Console.WriteLine(input);
			}

			Console.WriteLine("\nPress Any Key To Select Other Menu");
			Console.ReadKey();

        }

//   --------------------------------------- akhir function menampilkan anggota ---------------------------------



//	 --------------------------------------- awal function menampilkan anggota --------------------------------- 

        public void Cari_Mahasiswa(){

				int cari;
				int ketemu = 0, posisi = 0;

			Console.Write("\n\nNomor absen mahasiswa yang akan dicari = ");
			cari = Convert.ToInt32(Console.ReadLine());

			for (int n = 0; n <= input; n++){
				if (cari == MyGlobal[n].Id){
					ketemu = 1;
					posisi = n;

					Console.WriteLine(" mahasiswa dengan no absen ke {0} Ditemukan", cari);
					Console.WriteLine(" Nama Mahasiswa : " + MyGlobal[cari].Nama);
					Console.WriteLine(" Jenis Kelamin : " + MyGlobal[cari].Kelamin);
				}
			}

			if (ketemu == 0){
				Console.WriteLine("Maaf Data yang kamu cari tidak ada.");
			}

			Console.WriteLine("\nPress Any Key To Select Other Menu");
			Console.ReadKey();

        }

//   --------------------------------------- akhir function menampilkan anggota ---------------------------------



//	 --------------------------------------- awal function menampilkan anggota --------------------------------- 

        public void Hapus_Mahasiswa(){

			int hapus;
				
			Console.Write("\n\nMasukkan index data yang akan dihapus = ");
			hapus = Convert.ToInt32(Console.ReadLine());

			Array.Clear(MyGlobal, hapus, 1);

			Console.ReadKey();
						
        }

//   --------------------------------------- akhir function menampilkan anggota ---------------------------------


    }
}
