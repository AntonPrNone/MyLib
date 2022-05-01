using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    /// <summary>
    /// Работа с массивом
    /// </summary>
    public class ArrayTools
    {
        //-------------------------------------------------------------------------------------
        #region ReturnSubarray
        /// <summary>
        /// Возращает подмассив
        /// </summary>
        /// <param name="myArr">Массив</param>
        /// <param name="with">Индекс От</param>
        /// <param name="before">Индекс До</param>
        /// <returns></returns> 
        public static string[] ReturnSubarray(string[] myArr, int with=0, int before=-1)
        {
            before = before == -1 ? myArr.Length - 1 : before;
            string[] intermediateArray = new string[before - with + 1];
            for (int i = with; i <= before; i++)
            {
                intermediateArray[i - with] = myArr[i];
            }
            return intermediateArray;
        }

        /// <summary>
        /// Возращает подмассив
        /// </summary>
        /// <param name="myArr">Массив</param>
        /// <param name="with">Индекс От</param>
        /// <param name="before">Индекс До</param>
        /// <returns></returns>
        public static int[] ReturnSubarray(int[] myArr, int with=0, int before=-1)
        {
            before = before == -1 ? myArr.Length - 1 : before;
            int[] intermediateArray = new int[before - with + 1];
            for (int i = with; i <= before; i++)
            {
                intermediateArray[i - with] = myArr[i];
            }
            return intermediateArray;
        }

        /// <summary>
        /// Возращает подмассив
        /// </summary>
        /// <param name="myArr">Массив</param>
        /// <param name="with">Индекс От</param>
        /// <param name="before">Индекс До</param>
        /// <returns></returns>
        public static double[] ReturnSubarray(double[] myArr, int with=0, int before=-1)
        {
            before = before == -1 ? myArr.Length - 1 : before;
            double[] intermediateArray = new double[before - with + 1];
            for (int i = with; i <= before; i++)
            {
                intermediateArray[i - with] = myArr[i];
            }
            return intermediateArray;
        }

        /// <summary>
        /// Возращает подмассив
        /// </summary>
        /// <param name="myArr">Массив</param>
        /// <param name="with">Индекс От</param>
        /// <param name="before">Индекс До</param>
        /// <returns></returns>
        public static float[] ReturnSubarray(float[] myArr, int with=0, int before=-1)
        {
            before = before == -1 ? myArr.Length - 1 : before;
            float[] intermediateArray = new float[before - with + 1];
            for (int i = with; i <= before; i++)
            {
                intermediateArray[i - with] = myArr[i];
            }
            return intermediateArray;
        }

        /// <summary>
        /// Возращает подмассив
        /// </summary>
        /// <param name="myArr">Массив</param>
        /// <param name="with">Индекс От</param>
        /// <param name="before">Индекс До</param>
        /// <returns></returns>
        public static bool[] ReturnSubarray(bool[] myArr, int with=0, int before=-1)
        {
            before = before == -1 ? myArr.Length - 1 : before;
            bool[] intermediateArray = new bool[before - with + 1];
            for (int i = with; i <= before; i++)
            {
                intermediateArray[i - with] = myArr[i];
            }
            return intermediateArray;
        }

        /// <summary>
        /// Возращает подмассив
        /// </summary>
        /// <param name="myArr">Массив</param>
        /// <param name="with">Индекс От</param>
        /// <param name="before">Индекс До</param>
        /// <returns></returns>
        public static char[] ReturnSubarray(char[] myArr, int with=0, int before=-1)
        {
            before = before == -1 ? myArr.Length - 1 : before;
            char[] intermediateArray = new char[before - with + 1];
            for (int i = with; i <= before; i++)
            {
                intermediateArray[i - with] = myArr[i];
            }
            return intermediateArray;
        }

        /// <summary>
        /// Возращает подмассив
        /// </summary>
        /// <param name="myArr">Массив</param>
        /// <param name="with">Индекс От</param>
        /// <param name="before">Индекс До</param>
        /// <returns></returns>
        public static long[] ReturnSubarray(long[] myArr, int with=0, int before=-1)
        {
            before = before == -1 ? myArr.Length - 1 : before;
            long[] intermediateArray = new long[before - with + 1];
            for (int i = with; i <= before; i++)
            {
                intermediateArray[i - with] = myArr[i];
            }
            return intermediateArray;
        }

        /// <summary>
        /// Возращает подмассив
        /// </summary>
        /// <param name="myArr">Массив</param>
        /// <param name="with">Индекс От</param>
        /// <param name="before">Индекс До</param>
        /// <returns></returns>
        public static object[] ReturnSubarray(object[] myArr, int with=0, int before=-1)
        {
            before = before == -1 ? myArr.Length - 1 : before;
            object[] intermediateArray = new object[before - with + 1];
            for (int i = with; i <= before; i++)
            {
                intermediateArray[i - with] = myArr[i];
            }
            return intermediateArray;
        }
        #endregion
        //-------------------------------------------------------------------------------------
    }
}


