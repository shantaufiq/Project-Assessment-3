﻿using System;

namespace Project_Assessment_3
{
    class Program
    {
        struct Mahasiswa
		{
			public int Id;
			public string Nama;
			public string Kelamin;
			public int ntugas;
			public int nujian;
			public double ntotal;
			public double nratarata;
			public int terisi;
            
		}        
		
        static Mahasiswa[] MyGlobal = new Mahasiswa[10]; //? deklarasi variabel array global

//  !--------------------------------------- Awal Main Program -----------------------------------------------!
        
        public static void Main(string[] args)
        {
            Program p = new Program();
			
			
			string username;
			string password;

			// ?-> menu login
			login :
				Console.Clear();
				Console.WriteLine("      >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");
				Console.WriteLine("      |              		                                             |");
                Console.WriteLine("      |          Keep your head up girl. take your own desire                |");
                Console.WriteLine("      |          everyone can make a option in ur life, but nafiisa          |");
				Console.WriteLine("      |          still live on your soul. :)                    	     |");
				Console.WriteLine("      |              		                                             |");
				Console.WriteLine("      >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");
				
			// 	Console.Write("             Masukkan username : ");
			// 	username = Console.ReadLine();
			// 	Console.Write("             Masukkan password : ");
			// 	password = Console.ReadLine();

			// if ( username == "admin" && password == "admin123"){
			// 	goto menu;
			// } else {
			// 		Console.WriteLine("");
			// 		Console.WriteLine("                    ------------------****---------------------");
			// 		Console.WriteLine("");
			// 		Console.WriteLine("                   you entered the wrong username and password");		
			// 		Console.WriteLine("");		
			// 		Console.WriteLine("                    ------------------****---------------------");
			// 		Console.WriteLine("");
			// 		Console.WriteLine("                      Press Any Key for input a great password");
			// 		Console.WriteLine("");
			// 		Console.ReadKey();
			// 	goto login;
			// }
			Console.ReadKey();
				// ?-> akhir menu login


			
                
                menu : //?-> goto balik ke menu utama
                Console.Clear();
                Console.WriteLine("      ||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
				Console.WriteLine("      |              		                                             |");
                Console.WriteLine("      |               	PROGRAM DAFTAR ABSEN MAHASISWA                       |");
                Console.WriteLine("      |                    	KELAS D4SM-44-03                             |");
				Console.WriteLine("      |              		                                             |");
                Console.WriteLine("      |           KELOMPOK :	1. Muhammad Taufiq Shidiq                    |");
                Console.WriteLine("      |              		2. Muhammad Ainur Rafiq                      |");
				Console.WriteLine("      |           		3. Muhammad Gilang                           |");
                Console.WriteLine("      |              		                                             |");
                Console.WriteLine("      |              			                                     |");
                Console.WriteLine("      |              Ketikkan Angka untuk Memilih Salah Satu Menu            |");
                Console.WriteLine("      |_____________________________________________________________________ |");
				Console.WriteLine("      |              		                                             |");
                Console.WriteLine("      | 1. Menambahkan Data Mahasiswa / Ubah Data                 	     |");
                Console.WriteLine("      | 2. Menampilkan Data Mahasiswa      				     |");
                Console.WriteLine("      | 3. Mencari Data Mahasiswa      				             |");
                Console.WriteLine("      | 4. Menghapus Data Mahasiswa     			             |");
				Console.WriteLine("      | 4. Mengubah Data Mahasiswa					     |");
				Console.WriteLine("      |              		                                             |");
                Console.WriteLine("      |>>>>>>>>>>>>>>>>>>>>>>>>>  0. Exit or Back  <<<<<<<<<<<<<<<<<<<<<<<<<<|");

            try { //* digunakan untuk ngecheck apakah benar atau tidak inputan dari user

			Console.Write("\nInsert Number Of Menu : ");
			int masukan = Convert.ToInt32(Console.ReadLine());
			
			switch(masukan)
				{
					case 1:
						p.Tambah_Mahasiswa(); //* memanggil fungsi tambah dan ubah mahasiswa
						goto menu;
						
					case 2:
						p.Tampil_Mahasiswa(); //* memanggil fungsi yang digunakan untuk menampilkan data mahasiswa yang sudah diinpitkan
						goto menu;
						
					case 3:
						p.Cari_Mahasiswa(); //* memanggil fungsi yang digunakan untuk mencari
						goto menu;
						
					case 4:
						p.Hapus_Mahasiswa(); //* memanggil fungsi yang digunakan untuk menghapus
						goto menu;

					case 5:
						p.Ubah_Mahaiswa(); //* memanggil fungsi mengubah mahasiswa
						goto menu;
						
					case 0: //* digunakan padasaat user ingin keluar dari aplikasi
					Benerin:

						Console.Write("are you sure want to quit this aplication? -> yes or no : ");
						String jawaban = Console.ReadLine();

						switch(jawaban){
							case "yes" : 
								//* apabila user yakin untuk keluar dari aplikasi
								Console.WriteLine("-------------------------****-------------------------");
								Console.WriteLine("");
								Console.WriteLine("************ DO YOUR BEST AND THANK YOU **************");
								Console.WriteLine("");
								Console.WriteLine("-------------------------****-------------------------");
								Console.WriteLine("");
								break;
							case "no" :
								goto menu;
							default :
								//* apabila user belum yakin untuk keluar dari aplikasi
								Console.WriteLine("");
								Console.WriteLine("Please choose 'yes' or 'no'");
								Console.WriteLine("");
								Console.WriteLine("-------------****---------------");
								Console.WriteLine("");
								goto Benerin;
						} // -> akhir program menanyakan keluar

						Console.WriteLine("\nPress Any Key To Exit");
						Console.ReadKey();
						break;
								
					default:
						//* untuk ngeblok terjadinya pemilihan menu yang beda
						if (masukan < 0 || masukan > 4){
							Console.WriteLine("You just entered {0} which is a wrong menu", masukan);
						}

						Console.WriteLine("\nPress Any Key To Exit");
						Console.ReadKey();
						goto menu;

				} // -> akhir switch
					
			}catch (Exception e) {
				Console.WriteLine(e.Message);
				Console.WriteLine("You have to write a integer data type");
				Console.WriteLine("\nPress Any Key To Select Other Menu");
				Console.ReadKey();
				goto menu;
			}
        } // ?-> akhir main program

//  !--------------------------------------- Akhir Main Program -----------------------------------------------!



//  !--------------------------------------- awal function tambah Mahasiswa -------------------------------------!

        public void Tambah_Mahasiswa(){
			Console.WriteLine("");

            int index;

            Console.Write("Berapa jumlah anggota yang akan anda input : ");
            int j = Convert.ToInt32(Console.ReadLine());

            for(int i = 0 ; i < j;  i++){
				// Console.WriteLine("urutan index array {0}", i);
				Console.WriteLine("-------------------------------------------");
				Console.Write("Masukan Nomor absen mahasiswa ke : ");
				index = Convert.ToInt32(Console.ReadLine());

				for (int k = 0; k <= MyGlobal.Length; k++)
				{
					if (index == k) {
						
						MyGlobal[index - 1].Id = index;
						Console.WriteLine("");
						Console.Write("Masukkan nama Mahasiswa : ");
						MyGlobal[index - 1].Nama = Console.ReadLine();
						Console.WriteLine("");
						Console.Write("Masukkan jenis Kelamin : " );
						MyGlobal[index - 1].Kelamin = Console.ReadLine();
						Console.WriteLine("");
						Console.Write("Masukkan jumlah nilai tugas : ");
						MyGlobal[index - 1].ntugas = Convert.ToInt32(Console.ReadLine());
						Console.WriteLine("");
						Console.Write("Masukkan jumlah nilai ujian : ");
						MyGlobal[index - 1].nujian = Convert.ToInt32(Console.ReadLine());
						MyGlobal[index - 1].ntotal = MyGlobal[index - 1 ].ntugas + MyGlobal[index - 1 ].nujian;
						MyGlobal[index - 1].nratarata = MyGlobal[index - 1].ntotal / 2;
						MyGlobal[index - 1].terisi = 1;
						Console.WriteLine("--------------------------------------------");

					}
				}	
			} // -> akhir mother for

            Console.WriteLine("\n***** Succesfully Saved ! *****");
			Console.WriteLine("");
            Console.WriteLine("\nPress Any Key To Select Other Menu");
            Console.ReadKey();
            
        }
        
//  !--------------------------------------- akhir function tambah anggota -------------------------------------!



//  !--------------------------------------- awal function menampilkan Mahasiswa ---------------------------------! 

        public void Tampil_Mahasiswa(){
			Console.WriteLine("");
			
			for(int i = 0; i < MyGlobal.Length; i++){

				if(MyGlobal[i].terisi == 1){
					Console.WriteLine("-------------------------------------------");
					Console.WriteLine(" Nomor absen mahasiswa ke : " + MyGlobal[i].Id);
					Console.WriteLine("");
					Console.WriteLine(" Namaa Mahasiswa : " + MyGlobal[i].Nama);
					Console.WriteLine("");
					Console.WriteLine(" Jenis Kelamin : " + MyGlobal[i].Kelamin);
					Console.WriteLine("");
					Console.WriteLine(" Jumlah nilai tugas : " + MyGlobal[i].ntugas);
					Console.WriteLine("");
					Console.WriteLine(" Jumlah nilai ujian : " + MyGlobal[i].nujian);
					Console.WriteLine("");
					Console.WriteLine(" Jumlah nilai rata - rata : " + MyGlobal[i].nratarata);
					Console.WriteLine("-------------------------------------------");
				}

			}

			Console.WriteLine("");
			Console.WriteLine("\nPress Any Key To Select Other Menu");
			Console.ReadKey();

        }

//   !--------------------------------------- akhir function menampilkan Mahasiswa ---------------------------------!



//	 !--------------------------------------- awal function mencari Mahasiswa ---------------------------------! 

        public void Cari_Mahasiswa(){

				int cari;
				int ketemu = 0, posisi = 0;

			Console.Write("\n\nMasukan nomor absen mahasiswa yang akan dicari = ");
			cari = Convert.ToInt32(Console.ReadLine());

			for (int n = 0; n < MyGlobal.Length; n++){
				if (cari == MyGlobal[n].Id && MyGlobal[cari-1].terisi == 1){
					ketemu = 1;
					posisi = n;

					Console.WriteLine("-------------------------------------------");
					Console.WriteLine(" Mahasiswa dengan no absen ke-{0} Ditemukan", MyGlobal[cari-1].Id);
					Console.WriteLine("");
					Console.WriteLine(" Nama Mahasiswa : " + MyGlobal[cari-1].Nama);
					Console.WriteLine("");
					Console.WriteLine(" Jenis Kelamin : " + MyGlobal[cari-1].Kelamin);
					Console.WriteLine("");
					Console.WriteLine(" Jumlah nilai tugas : " + MyGlobal[cari-1].ntugas);
					Console.WriteLine("");
					Console.WriteLine(" Jumlah nilai ujian : " + MyGlobal[cari-1].nujian);
					Console.WriteLine("");
					Console.WriteLine(" Jumlah nilai rata - rata : " + MyGlobal[cari-1].nratarata);
					Console.WriteLine("");
					Console.WriteLine("-------------------------------------------");
				}

			}

			if (ketemu == 0){
				Console.WriteLine("Sorry, the data you are looking for does not exist.");
			}

			Console.WriteLine("\nPress Any Key To Select Other Menu");
			Console.ReadKey();

        }

//   !--------------------------------------- akhir function mencari Mahasiswa ---------------------------------!



//	 !--------------------------------------- awal function menghapus Mahasiswa ---------------------------------! 

        public void Hapus_Mahasiswa(){
			Console.WriteLine("");
			string hapus;
			int cari;
			int ketemu = 0, posisi = 0;

		//? mencari mahasiswa mana yang akan dihapus

			Console.Write("Nomor absen mahasiswa yang akan anda hapus = ");
			cari = Convert.ToInt32(Console.ReadLine());

			for (int n = 0; n < MyGlobal.Length; n++){

				if (cari == MyGlobal[n].Id && MyGlobal[cari-1].terisi == 1){
					ketemu = 1;
					posisi = n;

					Console.WriteLine("-------------------------------------------");
					Console.WriteLine(" Mahasiswa dengan no absen ke-{0} ", MyGlobal[cari-1].Id);
					Console.WriteLine("");
					Console.WriteLine(" Nama Mahasiswa : " + MyGlobal[cari-1].Nama);
					Console.WriteLine("");
					Console.WriteLine(" Jenis Kelamin : " + MyGlobal[cari-1].Kelamin);
					Console.WriteLine("");
					Console.WriteLine(" Jumlah nilai tugas : " + MyGlobal[cari-1].ntugas);
					Console.WriteLine("");
					Console.WriteLine(" Jumlah nilai ujian : " + MyGlobal[cari-1].nujian);
					Console.WriteLine("");
					Console.WriteLine(" Jumlah nilai rata - rata : " + MyGlobal[cari-1].nratarata);
					Console.WriteLine("-------------------------------------------");
					Console.WriteLine("");
				}

			}

			if (ketemu == 0){
				Console.WriteLine("Sorry, the data you are looking for does not exist.");
			}
				
		//? mencari mahasiswa mana yang akan dihapus

		//? awal section menanyakan yes or no -> eksekusi atau tidak

			Benerin: // awal menanyakan yes or no

			Console.Write("Are you sure want to delete this person? -> yes or no : ");
			hapus = Console.ReadLine();
			Console.WriteLine("");

			if(hapus == "yes"){
				Array.Clear(MyGlobal, cari - 1, 1);
				Console.WriteLine("");
				Console.WriteLine("***** Mahasiswa has been deleted *****");
				Console.WriteLine("\nPress Any Key To Select Other Menu");
				Console.ReadKey();
			} else if (hapus == "no"){
				Console.WriteLine("\nPress Any Key for back to menu");
				Console.ReadKey();
			} else {
				Console.WriteLine("");
				Console.WriteLine("Please choose 'yes' or 'no'");
				Console.WriteLine("");
				Console.WriteLine("-------------****---------------");
				Console.WriteLine("");
				goto Benerin;
			}

		//? akhir section menanyakan yes or no

        }

//   !--------------------------------------- akhir function menghapus Mahasiswa ---------------------------------!



//   !--------------------------------------- awal fungsi ubah mahasiswa ---------------------------------!

	public void Ubah_Mahaiswa() {
		Console.WriteLine("");
			string hapus;
			int cari;
			int ketemu = 0, posisi = 0;

		//? mencari mahasiswa mana yang ingin di ubah

			Console.Write("Nomor absen mahasiswa yang akan anda hapus = ");
			cari = Convert.ToInt32(Console.ReadLine());

			for (int n = 0; n < MyGlobal.Length; n++){

				if (cari == MyGlobal[n].Id && MyGlobal[cari-1].terisi == 1){
					ketemu = 1;
					posisi = n;

					Console.WriteLine("-------------------------------------------");
					Console.WriteLine(" Mahasiswa dengan no absen ke-{0} ", MyGlobal[cari-1].Id);
					Console.WriteLine("");
					Console.WriteLine(" Nama Mahasiswa : " + MyGlobal[cari-1].Nama);
					Console.WriteLine("");
					Console.WriteLine(" Jenis Kelamin : " + MyGlobal[cari-1].Kelamin);
					Console.WriteLine("");
					Console.WriteLine(" Jumlah nilai tugas : " + MyGlobal[cari-1].ntugas);
					Console.WriteLine("");
					Console.WriteLine(" Jumlah nilai ujian : " + MyGlobal[cari-1].nujian);
					Console.WriteLine("");
					Console.WriteLine(" Jumlah nilai rata - rata : " + MyGlobal[cari-1].nratarata);
					Console.WriteLine("-------------------------------------------");
					Console.WriteLine("");
				}

			}

			if (ketemu == 0){
				Console.WriteLine("Sorry, the data you are looking for does not exist.");
			}

			//? akhir dari mencari mahasiswa yang ingin diubah

			// ? sourch code ubah

			Console.WriteLine("");

            int index;

            int j = 1;

            for(int i = 0 ; i < j;  i++){
				// Console.WriteLine("urutan index array {0}", i);
				Console.WriteLine("-------------------------------------------");
				Console.Write("Masukan Nomor absen mahasiswa ke : ");
				index = Convert.ToInt32(Console.ReadLine());

				for (int k = 0; k <= MyGlobal.Length; k++)
				{
					if (index == k) {
						
						MyGlobal[index - 1].Id = index;
						Console.WriteLine("");
						Console.Write("Masukkan nama Mahasiswa : ");
						MyGlobal[index - 1].Nama = Console.ReadLine();
						Console.WriteLine("");
						Console.Write("Masukkan jenis Kelamin : " );
						MyGlobal[index - 1].Kelamin = Console.ReadLine();
						Console.WriteLine("");
						Console.Write("Masukkan jumlah nilai tugas : ");
						MyGlobal[index - 1].ntugas = Convert.ToInt32(Console.ReadLine());
						Console.WriteLine("");
						Console.Write("Masukkan jumlah nilai ujian : ");
						MyGlobal[index - 1].nujian = Convert.ToInt32(Console.ReadLine());
						MyGlobal[index - 1].ntotal = MyGlobal[index - 1 ].ntugas + MyGlobal[index - 1 ].nujian;
						MyGlobal[index - 1].nratarata = MyGlobal[index - 1].ntotal / 2;
						MyGlobal[index - 1].terisi = 1;
						Console.WriteLine("--------------------------------------------");

					}
				}	
			} // -> akhir mother for

            Console.WriteLine("\n***** Succesfully Saved ! *****");
			Console.WriteLine("");
            Console.WriteLine("\nPress Any Key To Select Other Menu");
            Console.ReadKey();

	}

//   !--------------------------------------- akhir fungsi ubah mahasiswa ---------------------------------!

    }
}
