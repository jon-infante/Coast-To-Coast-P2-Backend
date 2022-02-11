using Xunit;
using Models;
using CustomExceptions;
using System.Collections.Generic;
namespace Tests;

//Arrange
//Act
//Assert
public class ModelsTest
{
    [Fact]
    public void UserShouldMakeAccount(){
        
        Player testPlayer = new Player();
        Assert.NotNull(testPlayer);
    }
        [Fact]
    public void ShouldMakeCategory(){
        
        Category testCat = new Category();
        Assert.NotNull(testCat);
    }
        [Fact]
        public void ShouldMakeWallPost(){
        
        WallPost testPost = new WallPost();
        Assert.NotNull(testPost);
    }
        [Fact]
        public void ShouldMakeComment(){
        
        Comment testCom = new Comment();
        Assert.NotNull(testCom);
    }
        [Fact]
    public void ShouldMakeLike(){
        
        Like testCom = new Like();
        Assert.NotNull(testCom);
    }
            [Fact]
        public void ShouldMakeDrawing(){
        
        Drawing testCom = new Drawing();
        Assert.NotNull(testCom);
    }

    [Fact]
    public void PlayerShouldSetValidData(){
        Player testPlayer = new Player();
        int id = 123;
        string username = "Test Name";
        string password = "Test";
        int correctguesses = 1;
        int totalguesses = 1;
        decimal avgresult = 1;
        decimal avgscore = 1;


        testPlayer.Username = username;
        testPlayer.Password = password;
        testPlayer.CorrectGuesses= correctguesses;
        testPlayer.ID = id;
        testPlayer.TotalGuesses = totalguesses;
        testPlayer.AverageResult = avgresult;
        testPlayer.AverageScore = avgscore;

        Assert.Equal(username, testPlayer.Username);
        Assert.Equal(password, testPlayer.Password);
        Assert.Equal(id, testPlayer.ID);
        Assert.Equal(correctguesses, testPlayer.CorrectGuesses);
        Assert.Equal(totalguesses, testPlayer.TotalGuesses);
        Assert.Equal(avgresult, testPlayer.AverageResult);
        Assert.Equal(avgscore, testPlayer.AverageScore);

    }

    [Fact]
        public void CategoryShouldSetValidData(){
        Category testPlayer = new Category();
        int id = 123;
        string username = "Test Name";
   


        testPlayer.ID = id;
        testPlayer.CategoryName = username;


        Assert.Equal(id, testPlayer.ID);
        Assert.Equal(username, testPlayer.CategoryName);

    }

    


}