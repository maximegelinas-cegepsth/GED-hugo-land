using System.Collections;

namespace HugoLand
{
    public static class Extensions
    {
        public static int Count(this IEnumerable source)
        {
            var c = 0;
            var e = source.GetEnumerator();

            while (e.MoveNext())
            {
                c++;
            }
            
            return c;
        }
    }
}
