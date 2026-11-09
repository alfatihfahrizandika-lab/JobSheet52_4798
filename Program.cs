Console.Write("namaPelanggan =");
string namaPelanggan = (Console.ReadLine()!);

Console.Write("namaDokumen =");
string namaDokumen = (Console.ReadLine()!);

Console.Write("jumlahHalaman =");
int jumlahHalaman = int.Parse(Console.ReadLine()!);

Console.Write("hargaPerHalaman =");
int hargaPerHalaman = int.Parse(Console.ReadLine()!);

const int BiayaAdministrasi = 2000;

int subtotal = jumlahHalaman * hargaPerHalaman;
int Totalbayar = subtotal + BiayaAdministrasi;

Console.WriteLine();
Console.WriteLine("=== RINCIAN PENCETAKAN ===");
Console.WriteLine($"Nama pelanggan = {namaPelanggan}");
Console.WriteLine($"Nama dokumen = {namaDokumen}");
Console.WriteLine($"Jumlah halaman = {jumlahHalaman}");
Console.WriteLine($"Harga per halaman = {hargaPerHalaman}");
Console.WriteLine($"Subtotal = {subtotal}");
Console.WriteLine($"Biaya administrasi = {BiayaAdministrasi}");
Console.WriteLine($"Total bayar = {Totalbayar}");