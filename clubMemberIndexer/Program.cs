using System;

namespace Application { 
    class ClubMembers
    {
        public const int Size = 15;
        private string[] Members = new string[Size];
        public string ClubType { get; set; }
        public string ClubLocation { get; set; }
        public string MeetingDate { get; set; }

        // constructor
        public ClubMembers()
        {
            ClubType = ClubLocation = MeetingDate = string.Empty;
        }

        //indexer get and set methods
        public string this[uint i]
        {
            get => Members[i];
            set => Members[i] = value;
        }
    }

    class Program
    {
        public static void Main()
        {
            ClubMembers club = new ClubMembers();
            string[] members =
            {
                "Rachel",
                "Mike",
                "Samantha",
                "Jacob",
                "Richard"
            };
            uint added = 0;

            club.ClubType = "Gaming";
            club.ClubLocation = "1701 E Front St, Traverse City, MI 49686";
            club.MeetingDate = "10 Mar 2023";

            for(uint i=0;i<members.Length;i++)
            {
                club[i] = members[i];
                added++;
            }

            Console.WriteLine("Type: {0}", club.ClubType);
            Console.WriteLine("Location: {0}", club.ClubLocation);
            Console.WriteLine("Meeting Date: {0}", club.MeetingDate);

            for (uint i = 0; i < added; i++)
            {
                Console.WriteLine("Member #{0}: {1}", i+1, club[i]);
            }
        }
    }
}