using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n=== MENU ===");
            Console.WriteLine("1. Phep toan giua hai so");
            Console.WriteLine("2. Tinh gia tri ham x = y^2 + 2y + 1");
            Console.WriteLine("3. Tinh toc do tu khoang cach va thoi gian");
            Console.WriteLine("4. Tinh dien tich va the tich hinh cau");
            Console.WriteLine("5. Kiem tra ky tu");
            Console.WriteLine("6. Kiem tra so chan/le");
            Console.WriteLine("7. Tim so lon nhat trong ba so");
            Console.WriteLine("8. Xac dinh phan tu toa do");
            Console.WriteLine("9. Kiem tra loai tam giac");
            Console.WriteLine("10. Tinh tong va trung binh cua 10 so");
            Console.WriteLine("11. Bang cuu chuong");
            Console.WriteLine("12. Ve tam giac so don");
            Console.WriteLine("13. Ve cac mau pattern so");
            Console.WriteLine("14. Day so harmonic");
            Console.WriteLine("15. Tim so hoan hao trong khoang");
            Console.WriteLine("16. Kiem tra so nguyen to");
            Console.WriteLine("0. Thoat");
            Console.Write("Chon chuc nang (0-16): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": PhepToan(); break;
                case "2": HamSo(); break;
                case "3": TinhTocDo(); break;
                case "4": HinhCau(); break;
                case "5": KiemTraKyTu(); break;
                case "6": KiemTraChanLe(); break;
                case "7": TimSoLonNhat(); break;
                case "8": XacDinhPhanTu(); break;
                case "9": KiemTraTamGiac(); break;
                case "10": TongVaTrungBinh(); break;
                case "11": BangCuuChuong(); break;
                case "12": VeTamGiac(); break;
                case "13": VePatternSo(); break;
                case "14": DayHarmonic(); break;
                case "15": SoHoanHao(); break;
                case "16": KiemTraNguyenTo(); break;
                case "0": Console.WriteLine("Tam biet!"); return;
                default: Console.WriteLine("Lua chon khong hop le."); break;
            }
        }
    }

    // Các hàm từ menu gốc
    static void PhepToan() { /* giữ nguyên như trước */ }
    static void HamSo() { /* giữ nguyên như trước */ }
    static void TinhTocDo() { /* giữ nguyên như trước */ }
    static void HinhCau() { /* giữ nguyên như trước */ }
    static void KiemTraKyTu() { /* giữ nguyên như trước */ }
    static void KiemTraChanLe() { /* giữ nguyên như trước */ }
    static void TimSoLonNhat() { /* giữ nguyên như trước */ }
    static void XacDinhPhanTu() { /* giữ nguyên như trước */ }

    // Các bài tập mới thêm
    static void KiemTraTamGiac()
    {
        Console.Write("Nhap canh a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhap canh b: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhap canh c: ");
        int c = Convert.ToInt32(Console.ReadLine());

        if (a == b && b == c)
            Console.WriteLine("Tam giac deu.");
        else if (a == b || b == c || a == c)
            Console.WriteLine("Tam giac can.");
        else
            Console.WriteLine("Tam giac thuong.");
    }

    static void TongVaTrungBinh()
    {
        int sum = 0;
        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"Nhap so thu {i}: ");
            sum += Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine($"Tong = {sum}, Trung binh = {sum / 10.0}");
    }

    static void BangCuuChuong()
    {
        Console.Write("Nhap so nguyen: ");
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= 10; i++)
            Console.WriteLine($"{n} x {i} = {n * i}");
    }

    static void VeTamGiac()
    {
        Console.Write("Nhap so dong: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= i; j++)
                Console.Write(j);
            Console.WriteLine();
        }
    }

    static void VePatternSo()
    {
        for (int i = 1; i <= 4; i++)
        {
            // Cột 1
            for (int j = 1; j <= i; j++)
                Console.Write(j);
            Console.Write("\t");

            // Cột 2
            for (int j = 4 + i; j <= 6 + i; j++)
                Console.Write(j);
            Console.Write("\t");

            // Cột 3
            for (int j = 1 + (i - 1) * 2; j <= i * 2; j++)
                Console.Write(j);
            Console.WriteLine();
        }
    }

    static void DayHarmonic()
    {
        Console.Write("Nhap so n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        double sum = 0;
        for (int i = 1; i <= n; i++)
        {
            Console.Write($"1/{i} ");
            sum += 1.0 / i;
        }
        Console.WriteLine($"\nTong day harmonic = {sum:F4}");
    }

    static void SoHoanHao()
    {
        Console.Write("Nhap gioi han tren: ");
        int limit = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Cac so hoan hao:");
        for (int i = 2; i <= limit; i++)
        {
            int sum = 0;
            for (int j = 1; j < i; j++)
                if (i % j == 0) sum += j;
            if (sum == i)
                Console.WriteLine(i);
        }
    }

    static void KiemTraNguyenTo()
    {
        Console.Write("Nhap so nguyen: ");
        int n = Convert.ToInt32(Console.ReadLine());
        bool isPrime = n > 1;
        for (int i = 2; i <= Math.Sqrt(n); i++)
            if (n % i == 0) { isPrime = false; break; }

        Console.WriteLine(isPrime ? "La so nguyen to." : "Khong phai so nguyen to.");
    }
}