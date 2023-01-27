using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingProject
{
    public class HelperClass
    {

            public Boolean timeIsValid()
            {
                DateTime currentTime = DateTime.Now;

                switch (currentTime.DayOfWeek)
                {
                    case DayOfWeek.Sunday:

                        return false;

                    case DayOfWeek.Saturday:

                        if (currentTime.Hour >= 9 && currentTime.Hour <= 14)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    default:
                        if (currentTime.Hour >= 9 && currentTime.Hour <= 20)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }



                        //if ((currentTime.DayOfWeek).ToString()=="Sunday")
                        //{
                        //    return false;
                        //}

                        //else if ((currentTime.DayOfWeek).ToString() == "Saturday")
                        //{
                        //    if (currentTime.Hour >= 9 && currentTime.Hour <=14)
                        //    {
                        //        return true;
                        //    }
                        //    else
                        //    {
                        //        return false;
                        //    }
                        //}

                        //else
                        //{
                        //    if (currentTime.Hour >= 9 && currentTime.Hour <= 20)
                        //    {
                        //        return true;
                        //    }
                        //    else
                        //    {
                        //        return false;
                        //    }
                }
            }
        }
    }
