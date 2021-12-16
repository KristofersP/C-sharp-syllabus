using System;
using System.Collections.Generic;

namespace VideoStore
{
    public class VideoStore
    {
        private List<Video> _inventory;
        private Dictionary<string, Video> movies = new Dictionary<string, Video>();


        public VideoStore()
        {
            _inventory = new List<Video>();
        }

        public void AddVideo(string title)
        {
            _inventory.Add(new Video(title));
        }
        
        public void Checkout(string title)
        {
            foreach (var item in _inventory)
            {
                if(item.Title == title)
                {
                    item.BeingCheckedOut();
                    break;
                }
            }

        }

        public void ReturnVideo(string title)
        {
            foreach (var item in _inventory)
            {
                if (item.Title == title)
                {
                    item.BeingReturned();
                    break;
                }
            }
        }

        public void TakeUsersRating(double rating, string title)
        {
            foreach (var item in _inventory)
            {
                if (item.Title == title)
                {
                    item.ReceivingRating(rating);
                    break;
                }
            }
        }

        public void ListInventory()
        {
            foreach(var item in _inventory)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
