﻿using System;

namespace AOPGiris.Aspect.Attributes
{
    public class CacheAttribute : AspectBase, IBeforeAspect, IAfterVoidAspect
    {
        public int DurationInMinute { get; set; }

        public object OnBefore()
        {
            string cacheKey = string.Format("{0}_{1}", AspectContext.Instance.MethodName, string.Join("_", AspectContext.Instance.Arguments));

            if(true)
            {
                // gerekli cache key ile kontrol ederek varsa cache'de çağırım öncesi metot'u execute
                // etmeden cache üzerinden ilgili veriyi geri dön.

                Console.WriteLine("{0} isimli cache key ile cache üzerinden geliyorum!", cacheKey);
                return true;
            }
        }

        public void OnAfter(object value)
        {
            string cacheKey = string.Format("{0}_{1}", AspectContext.Instance.MethodName, string.Join("_", AspectContext.Instance.Arguments));

            // cache key ile ilgili veriyi DurationInMinute kullanarak Cache'e ekle veya güncelle.
        }
    }
}