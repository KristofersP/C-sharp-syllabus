namespace AdApp
{
    public class TVAd: Advert
    {
        private int _seconds;
        private int _rate;
        private bool _peakTime;
        public TVAd(int fee, int seconds, int rate, bool peakTime ) : base(fee)
        {
            _seconds = seconds;
            _rate = rate;
            _peakTime = peakTime;
        }
        
        public new int Cost() 
        {
            return _peakTime ? base.Cost() + _rate * 2 * _seconds: base.Cost() + _rate * _seconds;
        }

        public override string ToString() 
        {
            return base.ToString();
        }
    }
}