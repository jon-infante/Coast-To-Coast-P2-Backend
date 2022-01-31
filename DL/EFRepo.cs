using Models;
using Microsoft.EntityFrameworkCore;

namespace DL;

public class EFRepo : IRepo
{
    private DBContext _context;
    public EFRepo(DBContext context)
    {
        _context = context;
    }

    public List<Like> GetLikeByUserID(Like lk)
    {
        List<Like> likes = new List<Like> ();
        likes = _context.Likes.where(l => l.UserID = lk.UserID).ToList();
        return likes;
    }

    public List<Like> GetLikeByDrawingID(Like lk)
    {
        List<Like> likes = new List<Like> ();
        likes = _context.Likes.where(l => l.DrawingID = lk.DrawingID).ToList();
        return likes;
    }

    public List<Like> GetLikeByCommentID(Like lk)
    {
        List<Like> likes = new List<Like> ();
        likes = _context.Likes.where(l => l.CommentID = lk.CommentID).ToList();
        return likes;
    }

    public Like NewLike (Like lk)
    {
        Like like = new Like ();
        like = _context.Likes.Find.where(like => Likes.UserID = lk.UserID && Likes.DrawingID = lk.DrawingID && like.CommnetID = lk.CommentID);
        if (like == null)
        {
            like = _context.Likes.Add(lk);
        }
        return like;
    }

    public void RemoveLike (Like lk)
    {
        Like like = new Like ();
        like = _context.Likes.Find.where(like => Likes.UserID = lk.UserID && Likes.DrawingID = lk.DrawingID && like.CommnetID = lk.CommentID);
        if (like != null)
        {
            like = _context.Likes.Remove(lk);
        }
    }

    public List<Comment> GetCommentByDrawingID(Drawing draw)
    {
        List<Comment> comments = new List<Comment>();
        comments = _context.Comments.Find.where(c => c.DrawingID = draw.ID);
        return comments;
    }
}