# ds-queue-csharp

## Sub Capaian Pembelajaran

1. Mahasiswa mampu mengimplementasikan konsep struktur data queue
2. Mahasiswa mampu menggunakan struktur data queue buatan sendiri untuk studi kasus tertentu
3. Mahasiswa mampu menggunakan struktur data Queue<> bawaan framework .NET untuk studi kasus tertentu

## Lingkungan Pengembangan

1. Platform: .NET 6.0
2. Bahasa: C# 10
3. IDE: Visual Studio 2022

## Cara membuka project menggunakan Visual Studio

1. Clone repositori project `ds-queue-csharp` ke direktori lokal git Anda.
2. Buka Visual Studio, pilih menu File > Open > Project/Solution > Pilih file *.sln.
3. Tekan tombol Open untuk  untuk membuka solusi.
4. Baca soal dengan seksama. Buat implementasi kode sesuai dengan petunjuk.
6. Jalankan unit test di project *.Tests

> PERINGATAN: Push kode program ke remote repository jika hanya seluruh test case sudah lolos/passed (bertanda hijau).

## Soal-soal

### Soal: Antrian Layanan Pelanggan

Buat solusi dari soal ini di project `Solution` dalam folder `CustomerServiceQueue` dengan namespace `Solution.CustomerServiceQueue`.

Anda diminta untuk membuat sistem antrian layanan pelanggan menggunakan konsep Queue yang Anda implementasikan sendiri dalam C#. Sistem ini harus memungkinkan pengguna untuk:
1. Menambahkan pelanggan baru ke dalam antrian.
2. Mengambil pelanggan dari antrian untuk dilayani dan menghapusnya dari antrian.
3. Melihat pelanggan pertama dalam antrian tanpa menghapusnya.

#### Persyaratan:

1. **Kelas Pelanggan**: Buat kelas publik `Pelanggan` dengan properti `Nama` (string) dan `ID` (string). Kelas ini akan merepresentasikan setiap pelanggan dalam antrian. Sediakan konstruktor yang menginisialisasi kedua properti tersebut.

2. **Implementasi Queue Manual**: Implementasikan struktur data Queue manual menggunakan linked list untuk menyimpan objek `Pelanggan`. Buat kelas `CustomerQueue` dengan operasi dasar Queue seperti `Enqueue` (menambahkan ke antrian), `Dequeue` (mengambil dari antrian), dan `Peek` (melihat elemen pertama tanpa menghapus).

3. **Menambahkan Pelanggan**: Buat metode `Enqueue` dalam kelas `CustomerQueue` yang menerima parameter `Pelanggan` dan menambahkannya ke dalam antrian.

4. **Mengambil Pelanggan**: Buat metode `Dequeue` yang menghapus dan mengembalikan pelanggan pertama dari antrian. Jika antrian kosong, kembalikan nilai `null` atau pesan bahwa antrian kosong.

5. **Melihat Pelanggan Pertama**: Buat metode `Peek` yang mengembalikan pelanggan pertama dari antrian tanpa menghapusnya dari antrian. Jika antrian kosong, kembalikan nilai `null` atau pesan bahwa antrian kosong.

6. **Demo Program**: Buat kelas `Program` dengan metode `Main` untuk mendemonstrasikan penggunaan sistem antrian layanan pelanggan ini dengan beberapa skenario, seperti menambahkan beberapa pelanggan ke dalam antrian, mengambil pelanggan untuk dilayani, dan melihat pelanggan pertama dalam antrian.

#### Contoh Implementasi:

Misal, pengguna menambahkan pelanggan "Alice" dengan ID "A001", "Bob" dengan ID "B002", dan "Charlie" dengan ID "C003" ke dalam antrian. Sistem harus dapat menangani aksi mengambil pelanggan untuk dilayani dan melihat pelanggan pertama dengan benar.

#### Contoh Output:

```
Menambahkan pelanggan ke antrian: Alice (A001)
Menambahkan pelanggan ke antrian: Bob (B002)
Menambahkan pelanggan ke antrian: Charlie (C003)
Pelanggan pertama dalam antrian: Alice (A001)
Mengambil pelanggan dari antrian untuk dilayani: Alice (A001)
Pelanggan pertama dalam antrian sekarang: Bob (B002)
```

### Soal: Manajemen Pesanan Restoran dengan Queue

Buat solusi dari soal ini di project `Solution` dalam folder `RestaurantOrderQueue` dengan namespace `Solution.RestaurantOrderQueue`.

Anda diminta untuk membuat sistem manajemen pesanan untuk restoran menggunakan konsep Queue yang Anda implementasikan sendiri dalam C#. Sistem ini harus memungkinkan restoran untuk:
1. Menambahkan pesanan baru ke dalam antrian.
2. Mengambil pesanan dari antrian untuk diproses dan menghapusnya dari antrian.
3. Melihat pesanan pertama dalam antrian tanpa menghapusnya.

#### Persyaratan:

1. **Kelas Pesanan**: Buat kelas publik `Pesanan` dengan properti `IDPesanan` (string), `NamaPelanggan` (string), dan `Menu` (string). Kelas ini akan merepresentasikan setiap pesanan yang masuk ke restoran. Sediakan konstruktor yang menginisialisasi ketiga properti tersebut.

2. **Implementasi Queue Manual**: Implementasikan struktur data Queue manual menggunakan linked list untuk menyimpan objek `Pesanan`. Buat kelas `OrderQueue` dengan operasi dasar Queue seperti `Enqueue` (menambahkan ke antrian), `Dequeue` (mengambil dari antrian), dan `Peek` (melihat elemen pertama tanpa menghapus).

3. **Menambahkan Pesanan**: Buat metode `Enqueue` dalam kelas `OrderQueue` yang menerima parameter `Pesanan` dan menambahkannya ke dalam antrian.

4. **Mengambil Pesanan**: Buat metode `Dequeue` yang menghapus dan mengembalikan pesanan pertama dari antrian untuk diproses. Jika antrian kosong, kembalikan nilai `null` atau pesan bahwa antrian kosong.

5. **Melihat Pesanan Pertama**: Buat metode `Peek` yang mengembalikan pesanan pertama dari antrian tanpa menghapusnya. Jika antrian kosong, kembalikan nilai `null` atau pesan bahwa antrian kosong.

6. **Demo Program**: Buat kelas `Program` dengan metode `Main` untuk mendemonstrasikan penggunaan sistem manajemen pesanan restoran ini dengan beberapa skenario, seperti menambahkan beberapa pesanan ke dalam antrian, mengambil pesanan untuk diproses, dan melihat pesanan pertama dalam antrian.

#### Contoh Implementasi:

Misal, restoran menerima pesanan "Nasi Goreng" untuk "Alice", "Soto Ayam" untuk "Bob", dan "Bakso" untuk "Charlie". Sistem harus dapat menangani aksi mengambil pesanan untuk diproses dan melihat pesanan pertama dengan benar.

#### Contoh Output:

```
Menambahkan pesanan ke antrian: Nasi Goreng untuk Alice
Menambahkan pesanan ke antrian: Soto Ayam untuk Bob
Menambahkan pesanan ke antrian: Bakso untuk Charlie
Pesanan pertama dalam antrian: Nasi Goreng untuk Alice
Mengambil pesanan dari antrian untuk diproses: Nasi Goreng untuk Alice
Pesanan pertama dalam antrian sekarang: Soto Ayam untuk Bob
```

### Soal: Simulasi Antrian Pencetakan Dokumen

Buat solusi dari soal ini di project `Solution` dalam folder `PrintQueueSimulation` dengan namespace `Solution.PrintQueueSimulation`.

Anda diminta untuk membuat simulasi sistem antrian pencetakan dokumen di sebuah kantor atau lab komputer menggunakan konsep Queue dengan memanfaatkan kelas Queue bawaan dari .NET library. Sistem ini harus memungkinkan pengguna untuk:
1. Menambahkan dokumen ke dalam antrian pencetakan.
2. Memproses pencetakan dokumen satu per satu dari antrian dan menghapusnya setelah pencetakan selesai.
3. Melihat dokumen yang sedang dalam antrian untuk dicetak tanpa menghapusnya dari antrian.

#### Persyaratan:

1. **Kelas Dokumen**: Buat kelas publik `Dokumen` dengan properti `NamaFile` (string) dan `JumlahHalaman` (int). Kelas ini akan merepresentasikan setiap dokumen yang ingin dicetak. Sediakan konstruktor yang menginisialisasi kedua properti tersebut.

2. **Implementasi Queue**: Gunakan kelas Queue bawaan .NET untuk menyimpan objek `Dokumen`. Kelas Queue ini akan menjadi inti dari sistem antrian pencetakan Anda.

3. **Menambahkan Dokumen ke Antrian**: Buat metode `TambahDokumen` yang menerima parameter `Dokumen` dan menambahkannya ke dalam antrian pencetakan.

4. **Memproses Pencetakan**: Buat metode `ProsesPencetakan` yang mengambil dan menghapus dokumen pertama dari antrian untuk diproses (dicetak). Jika antrian kosong, kembalikan pesan bahwa antrian sedang kosong dan tidak ada dokumen untuk dicetak.

5. **Melihat Dokumen dalam Antrian**: Buat metode `LihatAntrian` yang menampilkan daftar semua dokumen yang sedang menunggu dalam antrian untuk dicetak, dengan informasi nama file dan jumlah halaman.

6. **Demo Program**: Buat kelas `Program` dengan metode `Main` untuk mendemonstrasikan penggunaan sistem antrian pencetakan dokumen ini dengan beberapa skenario, seperti menambahkan beberapa dokumen ke dalam antrian, memproses pencetakan, dan melihat dokumen yang sedang antri.

#### Contoh Implementasi:

Misalnya, terdapat dokumen "Proposal Project.docx" dengan 30 halaman, "Laporan Keuangan.xlsx" dengan 20 halaman, dan "Brosur Event.pdf" dengan 10 halaman yang ingin dicetak. Sistem harus dapat menangani aksi menambahkan dokumen ke antrian, memproses pencetakan, dan melihat dokumen yang antri dengan benar.

#### Contoh Output:

```
Menambahkan dokumen ke antrian: Proposal Project.docx, 30 halaman
Menambahkan dokumen ke antrian: Laporan Keuangan.xlsx, 20 halaman
Menambahkan dokumen ke antrian: Brosur Event.pdf, 10 halaman
Memproses pencetakan: Proposal Project.docx, 30 halaman
Melihat antrian dokumen:
- Laporan Keuangan.xlsx, 20 halaman
- Brosur Event.pdf, 10 halaman
```

### Soal: Manajemen Antrian Panggilan Darurat

Buat solusi dari soal ini di project `Solution` dalam folder `EmergencyQueue` dengan namespace `Solution.EmergencyQueue`.

Anda diminta untuk membuat simulasi sistem manajemen antrian panggilan darurat menggunakan konsep Queue dengan memanfaatkan kelas Queue bawaan dari .NET library. Sistem ini harus memungkinkan pengguna untuk:
1. Menambahkan panggilan darurat ke dalam antrian.
2. Menangani panggilan darurat satu per satu dari antrian berdasarkan urutan kedatangannya dan menghapusnya setelah panggilan tersebut selesai ditangani.
3. Melihat panggilan darurat yang sedang menunggu dalam antrian tanpa menghapusnya dari antrian.

#### Persyaratan:

1. **Kelas PanggilanDarurat**: Buat kelas publik `PanggilanDarurat` dengan properti `IDPanggilan` (string) dan `Deskripsi` (string). Kelas ini akan merepresentasikan setiap panggilan darurat yang diterima. Sediakan konstruktor yang menginisialisasi kedua properti tersebut.

2. **Implementasi Queue**: Gunakan kelas Queue bawaan .NET untuk menyimpan objek `PanggilanDarurat` di kelas publik `EmergencyCallCenter`. Kelas Queue ini akan menjadi inti dari sistem manajemen antrian panggilan darurat Anda.

3. **Menambahkan Panggilan Darurat ke Antrian**: Buat metode `TambahPanggilan` yang menerima parameter `PanggilanDarurat` dan menambahkannya ke dalam antrian panggilan darurat.

4. **Menangani Panggilan Darurat**: Buat metode `TanganiPanggilan` yang mengambil dan menghapus panggilan darurat pertama dari antrian untuk ditangani. Jika antrian kosong, kembalikan pesan bahwa antrian sedang kosong dan tidak ada panggilan untuk ditangani.

5. **Melihat Panggilan dalam Antrian**: Buat metode `LihatAntrianPanggilan` yang menampilkan daftar semua panggilan darurat yang sedang menunggu dalam antrian untuk ditangani, dengan informasi ID panggilan dan deskripsi.

6. **Melihat Jumlah Panggilan Darurat di Antrian**: Buat metode `QueueCount` yang mengembalikan jumlah panggilan darurat yang ada di dalam antrian.

7. **Demo Program**: Buat kelas `Program` dengan metode `Main` untuk mendemonstrasikan penggunaan sistem manajemen antrian panggilan darurat ini dengan beberapa skenario, seperti menambahkan beberapa panggilan darurat ke dalam antrian, menangani panggilan, dan melihat panggilan yang sedang antri.

#### Contoh Implementasi:

Misalnya, terdapat panggilan darurat dengan ID "EMG001" deskripsi "Kebakaran di gedung", ID "EMG002" deskripsi "Kecelakaan di jalan tol", dan ID "EMG003" deskripsi "Orang hilang di hutan". Sistem harus dapat menangani aksi menambahkan panggilan ke antrian, menangani panggilan, dan melihat panggilan yang antri dengan benar.

#### Contoh Output:

```
Menambahkan panggilan darurat ke antrian: EMG001, Kebakaran di gedung
Menambahkan panggilan darurat ke antrian: EMG002, Kecelakaan di jalan tol
Menambahkan panggilan darurat ke antrian: EMG003, Orang hilang di hutan
Menangani panggilan darurat: EMG001, Kebakaran di gedung
Melihat antrian panggilan darurat:
- EMG002, Kecelakaan di jalan tol
- EMG003, Orang hilang di hutan
```


=== Selesai ===


