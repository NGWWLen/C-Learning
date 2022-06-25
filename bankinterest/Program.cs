decimal interestRate = 0.0262m, depositAmount = 100.00m, serviceFee = 0.002m;
int months = 50 * 12;


for (int i = months; i!=0; i--)
{
    depositAmount = depositAmount + (depositAmount * interestRate);
    Console.WriteLine(depositAmount);
}

for (int i = 0; i < 50; i++)
{

}

//for (int i = months; i!=0; i--)
//{
//    depositAmount = depositAmount + (depositAmount * interestRate) - (depositAmount * serviceFee);
//    Console.WriteLine(depositAmount);
//}

