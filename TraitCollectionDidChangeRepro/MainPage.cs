using System.Collections.Generic;
using Xamarin.Forms;

namespace TraitCollectionDidChangeRepro
{
    public class MainPage : ContentPage
    {
        public MainPage()
        {
            var collectionView = new CollectionView
            {
                ItemsSource = CreateItemSource(),
            };

            Content = new RefreshView
            {
                Content = collectionView
            };
        }

        IEnumerable<string> CreateItemSource()
        {
            for (int i = 0; i < 100; i++)
                yield return $"Row {i}";
        }
    }
}
