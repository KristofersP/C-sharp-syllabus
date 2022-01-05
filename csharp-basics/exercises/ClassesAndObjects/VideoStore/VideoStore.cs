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

        public Video FindTitle(string title)
        {
            foreach (var item in _inventory)
            {
                if (item.Title == title)
                {
                    return item;
                }
            }
            return null;
        }
        
        public void Checkout(string title)
        {
            FindTitle(title).BeingCheckedOut();
        }

        public void ReturnVideo(string title)
        {
            FindTitle(title).BeingReturned();
        }

        public void TakeUsersRating(double rating, string title)
        {
            FindTitle(title).ReceivingRating(rating);
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
