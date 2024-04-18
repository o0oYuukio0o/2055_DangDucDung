using Domain;
using Microsoft.AspNetCore.Identity;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context,
            UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any() && !context.Activities.Any())
            {
                var users = new List<AppUser>
                {
                    new AppUser
                    {
                        DisplayName = "truongnhon",
                        UserName = "truongnhon",
                        Email = "truongnhon@gmail.com"
                    },
                    new AppUser
                    {
                        DisplayName = "ducdung",
                        UserName = "ducdung",
                        Email = "ducdung@gmail.com"
                    },
                    new AppUser
                    {
                        DisplayName = "phamtuan",
                        UserName = "phamtuan",
                        Email = "phamtuan@gmail.com"
                    },
                };

                foreach (var user in users)
                {
                    await userManager.CreateAsync(user, "P@ssw0rd");
                }
                var activities = new List<Activity>
                {
                    new Activity
                    {
                        Title = "Dã ngoại và Picnic tại Vườn Hoa Cẩm Tú",
                        Date = DateTime.UtcNow.AddMonths(-2),
                        Description = "Thư giãn và thưởng thức picnic giữa thiên nhiên",
                        Category = "outdoors",
                        City = "Hà Nội",
                        Venue = "Vườn Hoa Cẩm Tú",
                        Attendees = new List<ActivityAttendee>
                        {
                            new ActivityAttendee
                            {
                                AppUser = users[0], 
                                IsHost = true
                            },
                            new ActivityAttendee
                            {
                                AppUser = users[1], 
                                IsHost = false
                            }
                        }
                    },
                    new Activity
                    {
                        Title = "Dạo chơi và Tham quan Bảo tàng Dân tộc học Việt Nam",
                        Date = DateTime.UtcNow.AddMonths(-1),
                        Description = "Khám phá văn hóa dân tộc Việt Nam tại Bảo tàng Dân tộc học",
                        Category = "culture",
                        City = "Hà Nội",
                        Venue = "Bảo tàng Dân tộc học Việt Nam",
                        Attendees = new List<ActivityAttendee>
                        {
                            new ActivityAttendee
                            {
                                AppUser = users[0], 
                                IsHost = true
                            },
                            new ActivityAttendee
                            {
                                AppUser = users[1], 
                                IsHost = false
                            }
                        }
                    },
                    new Activity
                    {
                        Title = "Đêm nhạc Rock tại Câu lạc bộ Rock Fanatics",
                        Date = DateTime.UtcNow.AddMonths(1),
                        Description = "Trải nghiệm không khí sôi động với âm nhạc Rock tại Câu lạc bộ Rock Fanatics",
                        Category = "music",
                        City = "Hồ Chí Minh",
                        Venue = "Câu lạc bộ Rock Fanatics",
                        Attendees = new List<ActivityAttendee>
                        {
                            new ActivityAttendee
                            {
                                AppUser = users[2], 
                                IsHost = true
                            },
                            new ActivityAttendee
                            {
                                AppUser = users[1], 
                                IsHost = false
                            }
                        }
                    },
                    new Activity
                    {
                        Title = "Lớp Học Nấu Ăn: Ẩm thực Miền Trung",
                        Date = DateTime.UtcNow.AddMonths(2),
                        Description = "Học cách chế biến các món ăn truyền thống từ Miền Trung",
                        Category = "food",
                        City = "Đà Nẵng",
                        Venue = "Trường Dạy Nấu Ăn Miền Trung",
                        Attendees = new List<ActivityAttendee>
                        {
                            new ActivityAttendee
                            {
                                AppUser = users[0], 
                                IsHost = true
                            },
                            new ActivityAttendee
                            {
                                AppUser = users[2], 
                                IsHost = false
                            }
                        }
                    },
                    new Activity
                    {
                        Title = "Tham quan Làng Nghề Lịch Sử Dương Lâm",
                        Date = DateTime.UtcNow.AddMonths(3),
                        Description = "Khám phá nghề truyền thống và văn hóa tại làng nghề Dương Lâm",
                        Category = "culture",
                        City = "Hà Nội",
                        Venue = "Làng Nghề Dương Lâm",
                        Attendees = new List<ActivityAttendee>
                        {
                            new ActivityAttendee
                            {
                                AppUser = users[1], 
                                IsHost = true
                            },
                            new ActivityAttendee
                            {
                                AppUser = users[0], 
                                IsHost = false
                            }
                        }
                    },
                    new Activity
                    {
                        Title = "Dã ngoại và Lều trại tại Vịnh Hạ Long",
                        Date = DateTime.UtcNow.AddMonths(4),
                        Description = "Trải nghiệm cuộc sống ngoài trời và ngủ dưới bầu trời đêm tại Vịnh Hạ Long",
                        Category = "outdoors",
                        City = "Quảng Ninh",
                        Venue = "Vịnh Hạ Long",
                        Attendees = new List<ActivityAttendee>
                        {
                            new ActivityAttendee
                            {
                                AppUser = users[2], 
                                IsHost = true
                            },
                            new ActivityAttendee
                            {
                                AppUser = users[1], 
                                IsHost = false
                            }
                        }
                    },
                    new Activity
                    {
                        Title = "Trải nghiệm Văn hóa Dân dụng tại Làng Gốm Bát Tràng",
                        Date = DateTime.UtcNow.AddMonths(5),
                        Description = "Học cách làm gốm và hiểu sâu hơn về nghề gốm truyền thống",
                        Category = "culture",
                        City = "Hà Nội",
                        Venue = "Làng Gốm Bát Tràng",
                        Attendees = new List<ActivityAttendee>
                        {
                            new ActivityAttendee
                            {
                                AppUser = users[0], 
                                IsHost = true
                            },
                            new ActivityAttendee
                            {
                                AppUser = users[2], 
                                IsHost = false
                            }
                        }
                    },
                    new Activity
                    {
                        Title = "Du lịch Mạo Hiểm: Leo núi Fansipan",
                        Date = DateTime.UtcNow.AddMonths(6),
                        Description = "Chinh phục đỉnh cao Việt Nam với chuyến leo núi Fansipan",
                        Category = "outdoors",
                        City = "Lào Cai",
                        Venue = "Núi Fansipan",
                        Attendees = new List<ActivityAttendee>
                        {
                            new ActivityAttendee
                            {
                                AppUser = users[1], 
                                IsHost = true
                            },
                            new ActivityAttendee
                            {
                                AppUser = users[0], 
                                IsHost = false
                            }
                        }
                    },
                    new Activity
                    {
                        Title = "Lễ Hội Múa Lân Truyền Thống",
                        Date = DateTime.UtcNow.AddMonths(7),
                        Description = "Tham gia lễ hội múa lân truyền thống và khám phá nghệ thuật văn hóa đặc sắc",
                        Category = "culture",
                        City = "Hồ Chí Minh",
                        Venue = "Sân khấu trung tâm TP.HCM",
                        Attendees = new List<ActivityAttendee>
                        {
                            new ActivityAttendee
                            {
                                AppUser = users[2], 
                                IsHost = true
                            },
                            new ActivityAttendee
                            {
                                AppUser = users[1], 
                                IsHost = false
                            }
                        }
                    },
                    new Activity
                    {
                        Title = "Đêm Nhạc EDM tại Bar Club Volcano",
                        Date = DateTime.UtcNow.AddMonths(8),
                        Description = "Trải nghiệm không khí sôi động với nhạc EDM và đồ uống tại Bar Club Volcano",
                        Category = "music",
                        City = "Đà Nẵng",
                        Venue = "Bar Club Volcano",
                        Attendees = new List<ActivityAttendee>
                        {
                            new ActivityAttendee
                            {
                                AppUser = users[0], 
                                IsHost = true
                            },
                            new ActivityAttendee
                            {
                                AppUser = users[2], 
                                IsHost = false
                            }
                        }
                    }
                };

                await context.Activities.AddRangeAsync(activities);
                await context.SaveChangesAsync();
            }
        }
    }
}
