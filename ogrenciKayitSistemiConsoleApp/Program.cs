using System.Drawing;

namespace ogrenciKayitSistemiConsoleApp
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Vize { get; set; }
        public double Final { get; set; }

        public double CalculateGPA()
        {
            // Vize notunun %40'ı, Final notunun %60'ı etkileyecek şekilde not ortalamasını hesapla
            return Vize * 0.4 + Final * 0.6;
        }
    }

    class Program
    {
    
        static void Main()
        {
            List<Student> students = new List<Student>();

            Console.WriteLine("Öğrenci Kayıt Sistemi\n");
            Console.Clear();
            while (true)
            {
                Menu(students);
                SaveToFile(students);
             
            }
            
        }
        static void Menu(List<Student> students)
        {
            Console.WriteLine("1. Yeni öğrenci kaydı\n2. Tüm öğrencileri listele\n3. Öğrenci düzenle\n4. Öğrenci sil\n5. Dosyaları kaydet\n6. Read\n7. Çıkış ");
            ConsoleKeyInfo key = Console.ReadKey();

            Console.Clear();
            switch (key.Key)
            {
              
                case ConsoleKey.D1:
                    AddStudent(students);
                    Console.Beep();
                    break;
                case ConsoleKey.D2:
                    ListStudents(students);
                    break;
                case ConsoleKey.D3:
                    EditStudent(students);
                    Console.Beep();
                    break;
                case ConsoleKey.D4:
                    DeleteStudent(students);
                    Console.Beep();
                    break;
                case ConsoleKey.D5:
                    SaveToFile(students);
                    break;
                case ConsoleKey.D6:
                    ReadToFile(students);
                    break;
                case ConsoleKey.D7:                   
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("\nGeçersiz seçenek. Lütfen tekrar deneyin.");
                    break;
            }
        }

        static void AddStudent(List<Student> students)
        {
            Console.Write("Öğrenci adı: ");
            string name = Console.ReadLine();

            Console.Write("Öğrenci yaşı: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Vize notu: ");
            double vize = double.Parse(Console.ReadLine());

            Console.Write("Final notu: ");
            double final = double.Parse(Console.ReadLine());

            Student newStudent = new Student
            {
                Name = name,
                Age = age,
                Vize = vize,
                Final = final
            };

            students.Add(newStudent);

            Console.WriteLine($"{name} isimli öğrenci başarıyla kaydedildi.\n");
        }

        static void ListStudents(List<Student> students)
        {
            Console.WriteLine("\nÖğrenci Listesi:");
            foreach (var student in students)
            {
                Console.WriteLine($"Adı: {student.Name}, Yaşı: {student.Age}, Not Ortalaması: {student.CalculateGPA():F2}");
            }
            Console.WriteLine();
        }

        static void EditStudent(List<Student> students)
        {
            Console.Write("Düzenlemek istediğiniz öğrencinin adını girin: ");
            string nameToEdit = Console.ReadLine();

            Student studentToEdit = students.Find(student => student.Name == nameToEdit);

            if (studentToEdit != null)
            {
                Console.WriteLine($"Öğrenci bulundu. Yeni bilgileri girin:");

                Console.Write("Yeni öğrenci adı: ");
                studentToEdit.Name = Console.ReadLine();

                Console.Write("Yeni öğrenci yaşı: ");
                studentToEdit.Age = int.Parse(Console.ReadLine());

                Console.Write("Yeni vize notu: ");
                studentToEdit.Vize = double.Parse(Console.ReadLine());

                Console.Write("Yeni final notu: ");
                studentToEdit.Final = double.Parse(Console.ReadLine());

                Console.WriteLine("Öğrenci başarıyla düzenlendi.\n");
            }
            else
            {
                Console.WriteLine("Belirtilen isimde bir öğrenci bulunamadı.\n");
            }
        }

        static void DeleteStudent(List<Student> students)
        {
            Console.Write("Silmek istediğiniz öğrencinin adını girin: ");
            string nameToDelete = Console.ReadLine();

            Student studentToDelete = students.Find(student => student.Name == nameToDelete);

            if (studentToDelete != null)
            {
                students.Remove(studentToDelete);
                Console.WriteLine("Öğrenci başarıyla silindi.\n");
            }
            else
            {
                Console.WriteLine("Belirtilen isimde bir öğrenci bulunamadı.\n");
            }


        }

        static void SaveToFile(List<Student> students)
        {
            Console.Clear();


            using (StreamWriter writer = new StreamWriter("C:\\deneme\\deneme.txt")) 
            {
                foreach (var student in students)
                {
                    writer.WriteLine($"Adı: {student.Name}, Yaşı: {student.Age}, Not Ortalaması: {student.CalculateGPA():F2}");
                }
            }

            Console.WriteLine("Öğrenci bilgileri başarıyla dosyaya kaydedildi.");
        }
        static void ReadToFile(List<Student> students)
        {
            StreamReader reader = new StreamReader("C:\\deneme\\deneme.txt");
            string satir = reader.ReadLine();

            while (satir != null)
            {
                Console.WriteLine(satir);
                satir = reader.ReadLine();
            }

        }

    }
}