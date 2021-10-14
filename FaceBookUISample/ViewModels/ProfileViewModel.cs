using System;
using System.Collections.ObjectModel;
using FaceBookUISample.Models;

namespace FaceBookUISample.ViewModels
{
    public class ProfileViewModel
    {
        public ObservableCollection<Friends> friends { get; set; }
        public ObservableCollection<PrincipalComents> principalComents { get; set; }
        public ObservableCollection<PersonalInformation> personalInformation { get; set; }
        public ObservableCollection<PhotoRoll> photoRoll { get; set; }
        public ProfileViewModel()
        {

          photoRoll = new ObservableCollection<PhotoRoll>
            {
                new PhotoRoll {  Picture = "ProfileImage.jpg"   },
                new PhotoRoll {  Picture = "SunflowersTL.jpg"   },
                new PhotoRoll {  Picture = "TimeLineImage.jpg"  },
                new PhotoRoll {  Picture = "Girasol.jpg"        },
                new PhotoRoll {  Picture = "Agriculture.jpg"    },
                new PhotoRoll {  Picture = "Water.jpg"          },
            };


            personalInformation = new ObservableCollection<PersonalInformation>
            {
                new PersonalInformation
                {
                    Picture = "HomeIcon.png",
                    Description = "Vive en Santo Domingo"
                },
                new PersonalInformation
                {
                    Picture = "FromIcon.png",
                    Description = "De Santo Domingo"
                },
                new PersonalInformation
                {
                    Picture = "CivilStatusIcon.png",
                    Description = "Soltera"
                },
                 new PersonalInformation
                {
                    Picture = "LinkIcon.png",
                    Description = "AskXammy.com"
                } 
            };

            friends = new ObservableCollection<Friends>
            {
                new Friends
                {
                    Picture = "Friend1.jpg",
                    Name = "Vanessa Weiss"
                },
                new Friends
                {
                    Picture = "Friend2.jpg",
                    Name = "Paola Willys"
                },
                new Friends
                {
                    Picture = "Friend3.jpg",
                    Name = "Katty Prince"
                },
                new Friends
                {
                    Picture = "Friend4.jpg",
                    Name = "Amanda Scott"
                },
                new Friends
                {
                    Picture = "Friend5.jpg",
                    Name = "Keily Red"
                },
                new Friends
                {
                    Picture = "Friend6.jpg",
                    Name = "Josefa Perez"
                }
            };

            principalComents = new ObservableCollection<PrincipalComents>
            {
                 new PrincipalComents
                {
                    UserIcon = "ProfileImage.jpg",
                    PictureComment = "SunflowersTL.jpg",
                    Name="Leomaris Reyes",
                    Date="20 Junio 2019",
                    Comment="Hello people!!!",
                    Funny=true,
                    Like=true,
                    Love=false,
                    TotalComents="50 comments"
                },
                  new PrincipalComents
                {
                    UserIcon = "ProfileImage.jpg",
                    PictureComment = "Girasol.jpg",
                    Name="Leomaris Reyes",
                    Date="8 Junio 2019",
                    Comment="Esto es un comentario de prueba",
                    Funny=true,
                    Like=false,
                    Love=true,
                    TotalComents="10 comments"
                },
                  new PrincipalComents
                {
                    UserIcon = "ProfileImage.jpg",
                    PictureComment = "Agriculture.jpg",
                    Name="Leomaris Reyes",
                    Date="8 Junio 2019",
                    Comment="Esto es un comentario de prueba",
                    Funny=true,
                    Like=false,
                    Love=true,
                    TotalComents="10 comments"
                },
                  new PrincipalComents
                {
                    UserIcon = "ProfileImage.jpg",
                    PictureComment = "Water.jpg",
                    Name="Leomaris Reyes",
                    Date="8 Junio 2019",
                    Comment="Esto es un comentario de prueba",
                    Funny=true,
                    Like=false,
                    Love=true,
                    TotalComents="10 comments"
                }
            };

        }
    }
}
