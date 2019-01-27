using Xamarin.Forms;
using XamarinCourse.Essentials;
using XamarinCourse.Layouts.StackLayout.Exercise1;
using XamarinCourse.Layouts.StackLayout.Exercise2;
using XamarinCourse.Lists;

namespace XamarinCourse
{
    public class PageFactory
    {
        public ContentPage Build(PageType pageType)
        {
            switch (pageType)
            {
                case PageType.Essentials:
                    return new EssentialsPage();

                case PageType.StackLayoutExercise1:
                    return  new StackLayoutExercise1();

                case PageType.StackLayoutExercise2:
                    return new StackLayoutExercise2();

                case PageType.List:
                    return new ListPage();

                case PageType.CustomList:
                    return new CustomListPage();

                case PageType.CustomGroupedList:
                    return new CustomGroupedList();

                case PageType.ContextList:
                    return new ContextActionList();

                case PageType.PullToRefresh:
                    return new PullToRefreshPlusSearchList();
            }

            return null;
        }
    }
}