

/*
for (int i = 1; i < 10; i++)
{
    Console.Write("ddd");
}

// step 1

int j = 1;

// step 2

while(j < 10)
{
    Console.Write("ddd");

    // step 3
    j++;
}
*/

string[] boyName = new string[3];

boyName[0] = "Bhola"; // i=0
boyName[1] = "Sujeet"; // i=1
boyName[2] = "Ajeet"; // i=2;

//for (int i = 0; i < boyName.Length ; i++)
//{
//    Console.WriteLine(boyName[i]);
//}

int a = 0;

while(a <boyName.Length) // 0<3 , 1<3
{
    Console.WriteLine(boyName[a]);

    a++;

}





/*

1. step 1-int i = 1;- start
2. step 2 =i < 10 =1 < 10
 Console.Write("ddd");

3. step 3- i++ =2

step 2 =i < 10 =2 < 10
 Console.Write("ddd");

3. step 3- i++ =3

step 2 =i < 10 =3 < 10
 Console.Write("ddd")

3. step 3- i++ =3

 */