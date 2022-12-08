using System;

namespace HataYonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bir Sayı Girin");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girilen Sayı: " + sayi);   
            }
            catch (Exception ex)
           {
                Console.WriteLine("Hata: "+ ex.Message.ToString());
            
            }
            finally
            {
                Console.WriteLine("İşlem Tamamlandı");
            }

            try
            {
                //int a = int.Parse(null);
                //int a = int.Parse("test");
                int a = Convert.ToInt32(11111111111111111);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş Değer Girdiniz");
                Console.WriteLine(ex);
            }
            catch(FormatException ex)
            {   

                Console.WriteLine("Veri Tipi Uygun Değil");
                Console.WriteLine(ex);
            }
            catch(OverflowException ex){
                Console.WriteLine("Sayı Cok Büyük");
                Console.WriteLine(ex);
            }
            finally{
                Console.WriteLine("İşlem Tamamlandı.");
            }
        }
    }
}