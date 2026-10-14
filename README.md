Dalam repository ini berisi implementasi program Sistem Rumah Sakit berbasis console untuk memenuhi tugas mata kuliah PBO.
Program menggunakan method khusus pada turunan seperti:
-  'Diagnosa()' pada dokter
-  'menangis()' pada PasienAnak.
Penggunaan Inheritance dan Polymorrphism juga digunakan sebagai pewarisan dan overidding, yang di mana class 'Pasiien' dan 'TenagaMedis' mewarisi properti dari kelas 'Orang.
 
 ##Struktur Class
 * 'Orang' (Base Class)
  - 'TenagaMedis' (Derived Class)
    - 'Dokter'
    - 'Perawat'
  - 'Pasien' (Derived Class)
    - 'PasienAnak'
    - 'PasienDewasa'
* 'RumahSakit' (Class Pengelola Koleksi 'List<Orang>')
