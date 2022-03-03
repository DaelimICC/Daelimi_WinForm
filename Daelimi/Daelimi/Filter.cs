using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Daelimi
{
    internal class Filter
    {
        public int CheckPlace(String message)
        {
            int filter = 0;

            String text = message.Replace(" ", "");
            Regex Place = new Regex(@"수암관|수암도서관|수암관|수암도서관|도서관|
                                               수암관|WCC홀|한림관|방송실|한림관|체육관관람석|
                                               한림관|체육관|홍지관|언어치료센터|홍지관|글로벌잡스테이션|
                                           잡스테이션|홍지관|대림아트홀|퇴계관|에이스스테이션|퇴계관|
                                           대림학보사|대학본부|입학팀|대학본부|교육행정팀|대학본부|산학협력단|
                                             대학본부|링크사업단|임곡관|보건실|전산관|스마트스테이션");

            Regex RoomNum = new Regex(@"[ABCDEFGHJKLMNPV]0\d{3}");

            if(Place.IsMatch(text) || RoomNum.IsMatch(text))
            {
                filter = 1;
            }

            return filter;
        }
    }
}
