using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Student
{
     class Student:Program
    {
         public static int x=12; //   متغير لحفظ عدد الطلاب


        //------------------------------------------------------------------------------------------------------------------------

        public struct stu // سجل يحتوي على البيانات االرئيسية للطالب
        {
            public static int[] id = new int[x];
            public static string[] name = new string[x];
            public static int[] age = new int[x];
            public static string[] address = new string[x];
            public static int[] phone = new int[x];
            public static string[] stage = new string[x];
            public static double[] d1 = new double[x];
            public static double[] d2 = new double[x];
            public static double[] d3 = new double[x];
            public static double[] d4 = new double[x];
            public static double[] d5 = new double[x];
            public static double[] d6 = new double[x];
        };
        //------------------------------------------------------------------------------------------------------------------------
        public int t=1;
            public  void add() //  دالة لإضافة بيانات طالب
            {
            try
            {
                 for (int i = t-1; i < t; i++)
                {
                Console.Clear();
                //  البيانات الرئيسية للطالب
                Console.Write("\tPlease Enter Student_ID : ");
                    stu.id[i] = Convert.ToInt16(Console.ReadLine());
                    Console.Write("\tPlease Enter Student_Name : ");
                    stu.name[i] = Console.ReadLine();
                    Console.Write("\tPlease Enter Student_Age : ");
                    stu.age[i] = Convert.ToInt16(Console.ReadLine());
                    Console.Write("\tPlease Enter Student_Address : ");
                    stu.address[i] = Console.ReadLine();
                    Console.Write("\tPlease Enter Student_Phone : ");
                    stu.phone[i] = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\tPlease Enter Student_Stage : ");
                    stu.stage[i] = Console.ReadLine();

                //  درجات الطالب
                Console.WriteLine("\n-------------------------------------");
                    Console.Write("\tPlease Enter Student_Degree1 : ");
                    stu.d1[i] = Convert.ToDouble(Console.ReadLine());
                    Console.Write("\tPlease Enter Student_Degree2 : ");
                    stu.d2[i] = Convert.ToDouble(Console.ReadLine());
                    Console.Write("\tPlease Enter Student_Degree3 : ");
                    stu.d3[i] = Convert.ToDouble(Console.ReadLine());
                    Console.Write("\tPlease Enter Student_Degree4 : ");
                    stu.d4[i] = Convert.ToDouble(Console.ReadLine());
                    Console.Write("\tPlease Enter Student_Degree5 : ");
                    stu.d5[i] = Convert.ToDouble(Console.ReadLine());
                    Console.Write("\tPlease Enter Student_Degree6 : ");
                    stu.d6[i] = Convert.ToDouble(Console.ReadLine());
                }
            t++;
            }
            catch (e)
            {
                
                e;
            }
               
        }


            //------------------------------------------------------------------------------------------------------------------------

            public  void View()
            {
            try
            {
                  for (int i = 0; i < t; i++)
                {
                if (stu.id[i] != 0)
                {

                
                    Console.WriteLine("####################################################################################################################");
                    Console.Write("\n\n\n\t Student_ID : " + stu.id[i]);
                    Console.Write("\n\t Student_Name : " + stu.name[i]);
                    Console.Write("\n\t Student_Age : " + stu.age[i]);
                    Console.Write("\n\t Student_Address : " + stu.address[i]);
                    Console.Write("\n\t Student_Phone : " + stu.phone[i]);
                    Console.Write("\n\t Student_Stage : " + stu.stage[i]);
                    Console.WriteLine("\n------------------------------------------------------------------------------------------------");
                    Console.Write("\n\t Degree1\t Degree2\t Degree3\t Degree4\t Degree5\t Degree6");
                    Console.Write("\n\t   " + stu.d1[i] + "\t\t  " + stu.d2[i] + "\t\t  " + stu.d3[i] + "\t\t  " + stu.d4[i] + "\t\t  " + stu.d5[i] + "\t\t  " + stu.d6[i]);
                    Console.WriteLine("\n------------------------------------------------------------------------------------------------\n");
                    double sum = (stu.d1[i] + stu.d2[i] + stu.d3[i] + stu.d4[i] + stu.d5[i] + stu.d6[i]);
                     double avg = sum / 6;
                    Console.WriteLine("\n\t Sum : " +sum+"\t AVG : "+avg );
                    Console.WriteLine("\n------------------------------------------------------------------------------------------------\n\n");
                }

            }
            }
            catch (e)
            {
                
                EncoderFallbackException;
            }
              
            }
        public void delete(int c)
        {
            try
            {
                  for(int i=0;i<=t; i++)
            {
                if (stu.id[i] == c)
                {
                    stu.id[i] = 0;
                    MessageBox.Show("تم الحذف بنجاح");
                    Console.Clear();
                }
            }}
            catch (System.Exception)
            {
                
                System.Exception;
            }
          
              
            }
        }
        public void Amendment(int a)
        {
            try
            {
                  for (int i = 0; i <= t; i++)
            {
                if (stu.id[i] == a)
                {
                    Console.Clear();
                    Console.Write("\tPlease Enter Student_Name : ");
                    stu.name[i] = Console.ReadLine();
                    Console.Write("\tPlease Enter Student_Age : ");
                    stu.age[i] = Convert.ToInt16(Console.ReadLine());
                    Console.Write("\tPlease Enter Student_Address : ");
                    stu.address[i] = Console.ReadLine();
                    Console.Write("\tPlease Enter Student_Phone : ");
                    stu.phone[i] = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\tPlease Enter Student_Stage : ");
                    stu.stage[i] = Console.ReadLine();

                    //  درجات الطالب
                    Console.WriteLine("\n-------------------------------------");
                    Console.Write("\tPlease Enter Student_Degree1 : ");
                    stu.d1[i] = Convert.ToDouble(Console.ReadLine());
                    Console.Write("\tPlease Enter Student_Degree2 : ");
                    stu.d2[i] = Convert.ToDouble(Console.ReadLine());
                    Console.Write("\tPlease Enter Student_Degree3 : ");
                    stu.d3[i] = Convert.ToDouble(Console.ReadLine());
                    Console.Write("\tPlease Enter Student_Degree4 : ");
                    stu.d4[i] = Convert.ToDouble(Console.ReadLine());
                    Console.Write("\tPlease Enter Student_Degree5 : ");
                    stu.d5[i] = Convert.ToDouble(Console.ReadLine());
                    Console.Write("\tPlease Enter Student_Degree6 : ");
                    stu.d6[i] = Convert.ToDouble(Console.ReadLine());
                    MessageBox.Show("تم التعديل بنجاح");
                    Console.Clear();
                }
            
            
            }
            }
            catch (System.Exception)
            {
                
                System.Exception;
            }
          
        }
        public void Search(int s)
        {
            try
            {
                Console.Clear();
            for (int i=0;i<= t; i++)
            {
                
                if (stu.id[i] == s)
                {
                    Console.WriteLine("####################################################################################################################");
                    Console.Write("\n\n\n\t Student_ID : " + stu.id[i]);
                    Console.Write("\n\t Student_Name : " + stu.name[i]);
                    Console.Write("\n\t Student_Age : " + stu.age[i]);
                    Console.Write("\n\t Student_Address : " + stu.address[i]);
                    Console.Write("\n\t Student_Phone : " + stu.phone[i]);
                    Console.Write("\n\t Student_Stage : " + stu.stage[i]);
                    Console.WriteLine("\n------------------------------------------------------------------------------------------------");
                    Console.Write("\n\t Degree1\t Degree2\t Degree3\t Degree4\t Degree5\t Degree6");
                    Console.Write("\n\t   " + stu.d1[i] + "\t\t  " + stu.d2[i] + "\t\t  " + stu.d3[i] + "\t\t  " + stu.d4[i] + "\t\t  " + stu.d5[i] + "\t\t  " + stu.d6[i]);
                    Console.WriteLine("\n------------------------------------------------------------------------------------------------\n");
                    double sum = (stu.d1[i] + stu.d2[i] + stu.d3[i] + stu.d4[i] + stu.d5[i] + stu.d6[i]);
                    double avg = sum / 6;
                    Console.WriteLine("\n\t Sum : " + sum + "\t AVG : " + avg);
                    Console.WriteLine("\n------------------------------------------------------------------------------------------------\n\n");
                }
                
                
            }
            }
            catch (System.Exception)
            {
                
                System.Exception;
            }
            
            
        }
        }

    

