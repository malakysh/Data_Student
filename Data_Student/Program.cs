using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Data_Student
{
    class Program:Student
    {
        //public static int x = 0; //   متغير لحفظ عدد الطلاب
        public static int opr;  //  متغير لحفظ رقم العملية
        static void Main(string[] args)
        {
            Console.Title = "Data_Of_Student"; //   تغيير عنوان النافذة
            //       رسالة الترحيب
            //---------------------------------------------------------------------------
            try
            {
                Console.WriteLine("\n\n\n\n\n\n\n\n\t\t\t\t\t#################################");
                Console.WriteLine("\n\n\n\t\t\t\t\t\t.....  Welcome Nanny Ali  .....");
                Console.WriteLine("\n\n\n\t\t\t\t\t#################################\n");
                string fllowing = Console.ReadLine();
                Console.Clear();
            }
            catch
            {
                MessageBox.Show(" The data is incorrect");
            }
            //---------------------------------------------------------------------------

            Student s = new Student(); //  اشتقاق كائن من كلاس الطالب


        //---------------------------------------------------------------------------

        //          إختيار العمليات 
        //---------------------------------------------------------------------------


        a1:
            Console.Clear();
                Console.WriteLine("\n\n\n\t\tChoose one of the following operations :\n");
                Console.WriteLine("\t\t\t1- Add");
                Console.WriteLine("\t\t\t2- View all");
                Console.WriteLine("\t\t\t3- Delete");
                Console.WriteLine("\t\t\t4- Amendment");
                Console.WriteLine("\t\t\t5- Search");
                Console.WriteLine("\t\t\t6- Exit\n\n\n\t\t\t\t\t");
                opr = Convert.ToInt16(Console.ReadLine()); //  متغير لحفظ رقم العملية
                Console.Clear();
            

                //---------------------------------------------------------------------------

            // إستدعاء الدوال من كلاس الطالب بحسب رقم العملية المختارة من قبل المستخدم 


            if (opr == 1) // دالة إضافة البيانات
            { // start if (opr==1)

                try {
                    s.add(); // استدعاء دالة الإضافة
                    MessageBox.Show("تم الإضافة بنجاح");
                    Console.Clear();
                }
                catch
                {
                    MessageBox.Show("القيمة غير صحيحة");                }
            }// end if (opr==1)

            else if (opr == 2) // start if (opr==2)
            {

                Console.Clear();
                s.View(); // إستدعاء دالة العرض
                string b = Console.ReadLine(); // لبقاء الصفحة الحالية بدون مسح
                Console.Clear();

            }// end if (opr==2)
            else if (opr == 3)
            {// start if (opr==3)
                try {
                    Console.Clear();
                    Console.Write("\n\n\t Enter The Student_ID : ");
                    int d = Convert.ToInt16(Console.ReadLine());
                    s.delete(d); // إستدعاء دالة الحذف
                }
                catch
                {
                    MessageBox.Show("هذا الرقم غير موجود");
                }
            } // end if (opr==3)
            else if (opr == 4)
            {
                try {
                    Console.Clear();
                    Console.Write("\n\n\t Enter The Student_ID : ");
                    int a = Convert.ToInt16(Console.ReadLine());
                    s.Amendment(a); // استدعاء دالة التعديل
                }
                catch
                {
                    MessageBox.Show("هذا الرقم غير موجود");
                }
            }
            else if (opr == 5)
            {
                try
                {
                    Console.Clear();
                    Console.Write("\n\n\t Enter The Student_ID : ");
                    int se = Convert.ToInt16(Console.ReadLine());
                    s.Search(se); // استدعاء دالة البحث
                    string b = Console.ReadLine(); // لبقاء الصفحة الحالية بدون مسح
                }
                catch
                {
                    MessageBox.Show("هذا الرقم غير موجود");
                }
            }
            else 
            {
                Application.Exit();Environment.Exit(0);
            }
            goto a1; // العودة الى القائمة الرئيسية
        
            //---------------------------------------------------------------------------
            
            Console.ReadKey(); 
        }
        //------------------------------------------------------------------------------------------------------------------------

       

    }

}
