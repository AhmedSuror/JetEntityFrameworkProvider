﻿using System.Collections.ObjectModel;

namespace JetEntityFrameworkProvider.Test.Model16_OwnCollection
{
    public class PostCollection : ObservableCollection<Post>
    {
        public Post Add(string title, string content)
        {
            Post post = new Post
            {
                Title = title,
                Content = content
            };
            Add(post);
            return post;
        }
    }
}
