/* Program 01 - Average of a class of 40 students using counter-controlled repetion */

#include <stdio.h>

int main() 
{
	int counter;
	float note, total, average;

	/* startup phase */
	total = 0;
	counter = 1;

	/* processing phase */
	while (counter <=40) {
		printf("Type the note: ");
		scanf("%f", &note);
		total = total + note;
		counter = counter + 1;
		}

	/* completion phase */
	average = total / 40;
	printf("The class average is %f.1\n",average);
	
	return 0; /* indicates that the program has finished satisfactorily */
}
