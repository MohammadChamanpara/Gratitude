//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Gratitude
//{
//    public class Notification
//    {
//        public void CreateNotificationChannel()
//        {
//            if (Build.VERSION.SdkInt < BuildVersionCodes.O)
//            {
//                // Notification channels are new in API 26 (and not a part of the
//                // support library). There is no need to create a notification
//                // channel on older versions of Android.
//                return;
//            }

//            var channelName = Resources.GetString(Resource.String.channel_name);
//            var channelDescription = GetString(Resource.String.channel_description);
//            var channel = new NotificationChannel(CHANNEL_ID, channelName, NotificationImportance.Default)
//            {
//                Description = channelDescription
//            };

//            var notificationManager = (NotificationManager)GetSystemService(NotificationService);
//            notificationManager.CreateNotificationChannel(channel);
//        }
//    }
//}
