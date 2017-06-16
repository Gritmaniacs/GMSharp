using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace GMSharp.Test
{
    [TestClass]
    public class RoomTests
    {
        [TestMethod]
        public void Ctor_ShouldDeserializeRoom()
        {
            using (var inputFile = File.OpenRead("TestRoom.room.gmx"))
            {
                using (var xmlReader = new XmlTextReader(inputFile))
                {
                    var xmlSerializer = new XmlSerializer(typeof(Room));
                    var room = (Room)xmlSerializer.Deserialize(xmlReader);

                    Assert.AreEqual("Test Room", room.Caption);
                    Assert.AreEqual(160, room.Width);
                    Assert.AreEqual(128, room.Height);
                    Assert.AreEqual(8, room.VerticalSnap);
                    Assert.AreEqual(8, room.HorizontalSnap);
                    Assert.AreEqual(GMBool.False, room.IsIsometric);
                    Assert.AreEqual(60, room.Speed);
                    Assert.AreEqual(GMBool.False, room.IsPersistent);
                    Assert.AreEqual(2302755, room.Colour);
                    Assert.AreEqual(GMBool.True, room.ShowColour);
                    Assert.AreEqual("var x = 0;", room.Code);
                    Assert.AreEqual(GMBool.True, room.EnableViews);
                    Assert.AreEqual(GMBool.True, room.ClearViewBackground);
                    Assert.AreEqual(GMBool.True, room.ClearDisplayBuffer);

                    Assert.AreEqual(8, room.Backgrounds.Length);

                    Assert.AreEqual(GMBool.True, room.Backgrounds[0].IsVisible);
                    Assert.AreEqual(GMBool.False, room.Backgrounds[0].IsForeground);
                    Assert.AreEqual("bg_floortiles", room.Backgrounds[0].Name);
                    Assert.AreEqual(0, room.Backgrounds[0].X);
                    Assert.AreEqual(0, room.Backgrounds[0].Y);
                    Assert.AreEqual(GMBool.True, room.Backgrounds[0].IsHorizontallyTiled);
                    Assert.AreEqual(GMBool.True, room.Backgrounds[0].IsHorizontallyTiled);
                    Assert.AreEqual(0, room.Backgrounds[0].HorizontalSpeed);
                    Assert.AreEqual(0, room.Backgrounds[0].VerticalSpeed);
                    Assert.AreEqual(GMBool.False, room.Backgrounds[0].Stretch);

                    for (int i = 1; i < 8; i++)
                    {
                        var background = room.Backgrounds[i];

                        Assert.AreEqual(GMBool.False, background.IsVisible);
                        Assert.AreEqual(GMBool.False, background.IsForeground);
                        Assert.AreEqual(string.Empty, background.Name);
                        Assert.AreEqual(0, background.X);
                        Assert.AreEqual(0, background.Y);
                        Assert.AreEqual(GMBool.True, background.IsHorizontallyTiled);
                        Assert.AreEqual(GMBool.True, background.IsHorizontallyTiled);
                        Assert.AreEqual(0, background.HorizontalSpeed);
                        Assert.AreEqual(0, background.VerticalSpeed);
                        Assert.AreEqual(GMBool.False, background.Stretch);
                    }

                    Assert.AreEqual(8, room.Views.Length);

                    Assert.AreEqual(GMBool.True, room.Views[0].IsVisible);
                    Assert.AreEqual("<undefined>", room.Views[0].ObjectName);
                    Assert.AreEqual(0, room.Views[0].X);
                    Assert.AreEqual(0, room.Views[0].Y);
                    Assert.AreEqual(160, room.Views[0].Width);
                    Assert.AreEqual(284, room.Views[0].Height);
                    Assert.AreEqual(0, room.Views[0].ViewportX);
                    Assert.AreEqual(0, room.Views[0].ViewportY);
                    Assert.AreEqual(160, room.Views[0].ViewportWidth);
                    Assert.AreEqual(284, room.Views[0].ViewportHeight);
                    Assert.AreEqual(320, room.Views[0].HorizontalBorder);
                    Assert.AreEqual(320, room.Views[0].VerticalBorder);
                    Assert.AreEqual(5, room.Views[0].HorizontalSpeed);
                    Assert.AreEqual(5, room.Views[0].VerticalSpeed);

                    for (int i = 1; i < 8; i++)
                    {
                        var view = room.Views[i];

                        Assert.AreEqual(GMBool.False, view.IsVisible);
                        Assert.AreEqual("<undefined>", room.Views[0].ObjectName);
                        Assert.AreEqual(0, view.X);
                        Assert.AreEqual(0, view.Y);
                        Assert.AreEqual(1024, view.Width);
                        Assert.AreEqual(768, view.Height);
                        Assert.AreEqual(0, view.ViewportX);
                        Assert.AreEqual(0, view.ViewportY);
                        Assert.AreEqual(1024, view.ViewportWidth);
                        Assert.AreEqual(768, view.ViewportHeight);
                        Assert.AreEqual(32, view.HorizontalBorder);
                        Assert.AreEqual(32, view.VerticalBorder);
                        Assert.AreEqual(-1, view.HorizontalSpeed);
                        Assert.AreEqual(-1, view.VerticalSpeed);
                    }

                    Assert.AreEqual(12, room.Instances.Length);

                    Assert.AreEqual("obj_checkpoint", room.Instances[0].ObjectName);
                    Assert.AreEqual(32, room.Instances[0].X);
                    Assert.AreEqual(24, room.Instances[0].Y);
                    Assert.AreEqual("inst_D451F6B2", room.Instances[0].Name);
                    Assert.AreEqual(GMBool.False, room.Instances[0].IsLocked);
                    Assert.AreEqual(string.Empty, room.Instances[0].Code);
                    Assert.AreEqual(1.0, room.Instances[0].XScale);
                    Assert.AreEqual(1.0, room.Instances[0].YScale);
                    Assert.AreEqual(4294967295, room.Instances[0].Colour);
                    Assert.AreEqual(0.0, room.Instances[0].Rotation);

                    Assert.AreEqual(21, room.Tiles.Length);

                    Assert.AreEqual("bg_checkpoint", room.Tiles[0].BackgroundName);
                    Assert.AreEqual(8, room.Tiles[0].X);
                    Assert.AreEqual(32, room.Tiles[0].Y);
                    Assert.AreEqual(144, room.Tiles[0].Width);
                    Assert.AreEqual(96, room.Tiles[0].Height);
                    Assert.AreEqual(0, room.Tiles[0].XOrigin);
                    Assert.AreEqual(0, room.Tiles[0].YOrigin);
                    Assert.AreEqual(10000351, room.Tiles[0].Id);
                    Assert.AreEqual("inst_A9169C12", room.Tiles[0].Name);
                    Assert.AreEqual(1000010, room.Tiles[0].Depth);
                    Assert.AreEqual(GMBool.False, room.Tiles[0].IsLocked);
                    Assert.AreEqual(4294967295, room.Tiles[0].Colour);
                    Assert.AreEqual(1.0, room.Tiles[0].XScale);
                    Assert.AreEqual(1.0, room.Tiles[0].YScale);


                    Assert.AreEqual(GMBool.False, room.IsPhysicsWorld);
                    Assert.AreEqual(0, room.PhysicsWorldTop);
                    Assert.AreEqual(0, room.PhysicsWorldLeft);
                    Assert.AreEqual(1024, room.PhysicsWorldRight);
                    Assert.AreEqual(768, room.PhysicsWorldBottom);
                    Assert.AreEqual(0, room.PhysicsWorldGravityX);
                    Assert.AreEqual(10, room.PhysicsWorldGravityY);
                    Assert.AreEqual(0.100000001490116, room.PhysicsWorldPixToMeters);
                }
            }
        }
    }
}
