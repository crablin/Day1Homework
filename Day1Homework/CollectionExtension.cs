using System;
using System.Collections.Generic;

namespace Day1Homework
{
    public static class CollectionExtension
    {
        /// <summary>
        /// 取得任何型別幾筆一組的總合列表
        /// </summary>
        /// <typeparam name="TSource">泛型物件</typeparam>
        /// <param name="source">來源資料</param>
        /// <param name="selector">指定來源特定欄位</param>
        /// <param name="groupCount">群組個數</param>
        /// <returns></returns>
        public static List<int> SumByGroup<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector, int groupCount)
        {
            var result = new List<int>();
            int index = 0;
            int counter = 0;
            
            foreach (TSource element in source)
            {
                index = counter / groupCount;

                if (result.Count == index)
                {
                    result.Add(0);
                }

                result[index] += selector(element);
                counter++;
            }

            return result;
        }

    }
}
