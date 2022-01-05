using System.Collections.Generic;
using System.Linq;
using System;

namespace VideoStore
{
    public class Video
    {
        private string _title;
        private bool _isCheckedOut;
        private List<double> _rating;

        public Video(string title)
        {
            _title = title;
            _rating = new List<double>();
        }

        public void BeingCheckedOut()
        {
            _isCheckedOut = true;
        }

        public void BeingReturned()
        {
            _isCheckedOut = false;
        }

        public void ReceivingRating(double rating)
        {
            _rating.Add(rating);
        }

        public double AverageRating()
        {
            return _rating.Average();
            
        }

        public bool Available()
        {
            return _isCheckedOut ? false : true;
        }

        public string Title => _title;

        public override string ToString()
        {
            return $"{Title} {Math.Round(AverageRating(),1)} {Available()}";
        }
    }
}
