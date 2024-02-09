# include <stdio.h>

void main(void)
{
	int NRO;
	for (NRO = 1; NRO <= 100; NRO++)
	{
		if (!(NRO%2)) /* Check if the number is odd or even */
		printf("The number %d is even.\n", NRO);
	}
}
