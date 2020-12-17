Console application
Regular expressions exersise

# NetherRealms
Mighty battle is coming. In the stormy nether realms, demons are fighting against each other for supremacy in a duel from which only one will survive. <br/>
Your job, however is not so exciting. You are assigned to __sign in all the participants__ in the nether realm's mighty battle's demon book, which of course is __sorted alphabetically__. <br/>
A demon's __name contains his health and his damage__. <br/>
The __sum of the asci codes__ of __all characters__ (excluding numbers (0-9), arithmetic symbols (__'+', '-', '*', '/'__) and delimiter dot (__'.'__)) gives a __demon's total health__.<br/> 
__The sum of all numbers__ in his name forms his base damage. Note that you should consider the plus __'+'__ and minus __'-'__ signs (e.g. __+10 is 10__ and __-10 is -10__). However, there are some symbols (__'*'__ and __'/'__) that can further __alter the base damage by multiplying or dividing it by 2__ (e.g. in the name "m15*/c-5.0", the base damage is __15 + (-5.0) = 10__ and then you need to multiply it by 2 (e.g. 10 * 2 = 20) and then divide it by 2 (e.g. 20 / 2 = 10)). <br/>
So, __multiplication and division__ are applied __only after all numbers are included__ in the calculation and __in the order they appear in the name__. <br/>
You will get all demons __on a single line__, separated by commas and zero or more blank spaces. Sort them in __alphabetical order__ and print their names __along their health and damage__. 
## Input
The input will be read from the console. The input consists of a __single line__ containing all demon names __separated by commas and zero or more spaces__ in the format: __"{demon name}, {demon name}, … {demon name}"__
## Output
Print all demons __sorted by their name in ascending order__, each on a separate line in the format:
* __"{demon name} - {health points} health, {damage points} damage"__
## Constraints
* A demon's name will contain __at least one character__
* A demon's name __cannot contain__ blank spaces ' ' or commas ','
*	A __floating point number will always have digits before and after its decimal separator__
*	__Number__ in a demon's name __is considered__ everything that is a valid integer or floating point number (with dot '.' used as separator). For example, all these are valid numbers: '4', '+4', '-4', '3.5', '+3.5', '-3.5' 
## Examples
Input |	Output  |	Comments
------|---------|---------
M3ph-0.5s-0.5t0.0** |M3ph-0.5s-0.5t0.0** - 524 health, 8.00 damage  |M3ph-0.5s-0.5t0.0**: 
-|-|Health = 'M' + 'p' + 'h' + 's' + 't' = 524 health.
-|-|Damage = (3 + (-0.5) + (-0.5) + 0.0) * 2 * 2 = 8 damage.
M3ph1st0**, Azazel  |Azazel - 615 health, 0.00 damage |Azazel: Health - 'A' + 'z' + 'a' + 'z' + 'e' + 'l' = 615 health. Damage - no digits = 0 damage.
-|M3ph1st0** - 524 health, 16.00 damage |M3ph1st0**: Health - 'M' + 'p' + 'h' + 's' + 't' = 524 health. Damage - (3 + 1 + 0) * 2 * 2 = 16 damage.
Gos/ho	|Gos/ho - 512 health, 0.00 damage	
