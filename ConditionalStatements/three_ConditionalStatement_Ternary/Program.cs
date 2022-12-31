

// Ternary condition  short form of if-else statement 

int age = 18;

bool IsAllowedVote;

if (age > 18)
{
    IsAllowedVote = true;
}
else
{
    IsAllowedVote = false;
}

//================Ternary =condition ? expression1 : expression2

int x = 10;
int y = 20;

int max = (x > y) ? x : y;

//==================================
if (x > y)
{
    Console.Write(x);
}
else
{
    Console.Write(y);
}