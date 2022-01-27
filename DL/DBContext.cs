using Microsoft.EntityFrameworkCore;

namespace DL;
public class DBContext : DbContext
{
    // Empty constructor for RRDBContext, that calls the empty constructor for DbContext
    public DBContext() : base() { }

    //if I need to pass in the options, I'm also just going to call my parent's constructor that takes in options via constructor chaining
    public DBContext(DbContextOptions options) : base(options) { }

    public DbSet<Player> Players { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<Drawing> Drawings { get; set; }
    public DbSet<WallPost> WallPosts { get; set; }


}