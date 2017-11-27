using System.Collections.Generic;

namespace PhotoShare.Models
{
    public class Album
    {
        private ICollection<Picture> pictures;
        private ICollection<AlbumTag> albumTags;
        private ICollection<AlbumRole> albumRoles;

        public Album(string name)
            :this()
        {
            this.Name = name;
        }

        public Album()
        {
            this.Pictures = new HashSet<Picture>();
            this.AlbumTags = new HashSet<AlbumTag>();
            this.AlbumRoles = new HashSet<AlbumRole>();
        }

        public Album(string name, Color backgroundColor)
            : this()
        {
            this.Name = name;
            this.BackgroundColor = backgroundColor;
        }



        public int Id { get; set; }

        public string Name { get; set; }

        public Color? BackgroundColor { get; set; }

        public bool IsPublic { get; set; }

        public ICollection<AlbumRole> AlbumRoles
        {
            get { return this.albumRoles; }
            set { this.albumRoles = value; }
        }

        public ICollection<Picture> Pictures
        {
            get { return this.pictures; }
            set { this.pictures = value; }
        }

        public ICollection<AlbumTag> AlbumTags
        {
            get { return this.albumTags; }
            set { this.albumTags = value; }
        }

        public override string ToString()
        {
            return $"{this.Name} has {this.Pictures.Count} pictures";
        }
    }
}
