namespace mutlak_karealma
{
public class NumberResult
    {
        public int KucukToplam { get; set; }
        public int BuyukToplam { get; set; }

        public override string ToString()
        {
            return $"{KucukToplam} {BuyukToplam}";
        }
    }
}
