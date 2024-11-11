string personName = Console.ReadLine();
//checking if the first name is an empty input
if (personName == "") return;

int extraLikesCounter = 0;
int numPeopleLiked = 0;

string likeMessage = null;
string postLikeMessage = "liked your post!";
string peopleLiked = personName;

numPeopleLiked++;

while (true) { 
    //checking for how many people liked
    switch (numPeopleLiked)
    {
        case 1:
            //printing first like message
            likeMessage = $"{peopleLiked} {postLikeMessage}";
            Console.WriteLine(likeMessage);
            break;
        case 2:
            peopleLiked += $" and {personName}";
            likeMessage = $"{peopleLiked} {postLikeMessage}";
            Console.WriteLine(likeMessage);
            //replacing the "and" with "," for the default case message
            peopleLiked = peopleLiked.Replace(" and", ",");
            break;
        //when the amount of people that liked is greater than 2
        default:
            //counting all extra people that have liked the post
            extraLikesCounter++;
            //new end part of message
            postLikeMessage = $"and {extraLikesCounter} other liked your post!";
            //printing out message
            likeMessage = $"{peopleLiked} {postLikeMessage}";
            Console.WriteLine(likeMessage);
            break;
    }
    //adding to the total num of people that liked
    numPeopleLiked++;
    //reading new name
    personName = Console.ReadLine();
    //checking if the the new name is an empty input
    if (personName == "") return;
}