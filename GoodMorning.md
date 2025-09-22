# GOOD MORNING

    -write a program that changes output depending on conditions
        -con 1. time of day
        -con 2. day.
        -con 3. date
        -con 4. weather

- Example of what will be written. Morning
  "God morgen. Klokken er 09.10.
  Det er Onsdag 17 September 2025.
  Teperaturen er +14 grader ute og overskyet.
  Det kan være lurt å ta med regntøy."

- Example midday
  "God ettermiddag. Klokken er 16.34.
  Det er Onsdag 17 September 2025.
  Temperaturen ute er +20 grader og skyfritt.
  Husk solkrem."

- Example evening
  "God kveld. Klokken er 19.07
  Det er Onsdag 17 September.
  Temperaturen er -2 grader og skyfritt.
  Det er kaldt ute. Ta på en jakke."

# NEW IDEA

    the new idea for this come from personal experience within family.
    My grandmother has dementia, and while talking to my mother during dinner,
    she said that there is no clock thats easy to use or understand for those with Alzheimers.
    The new idea is that I will use this project to make a clock easy to use for those suffering
    from either dementia or have problems with technology.

    The finished product will not be produced by me, but rather the idea of it.
    The product should be a device like a Rπ with one button. The button will work like a macro,
    that first clear the line, and then runs the code, to have a fresh terminal for each use.

    when pressing button, the clock should tell the user TIME DAY DATE MONTH TEMP PERCIP with voice

    EX
    God morgen/formiddag/ettermiddag/kveld Chris. Klokken er 00:00, I dag er det DAG DD/MM, det er 0.0 Grader ute, Ingen regn.


    this here is an example of what to press to get time, temp and percip.
    connecting this to a raspberry π with a small speaker
    and people who are not able to read a watch can get the time spoken to them

    https://www.amazon.com/Yoqanr-Programmable-Keyboard-Decision-Customized/dp/B0FB8WV74R?th=1




# API

        Get API from weather
        - Find API.
        - Learn how to implement API from weather source.
        - Learn how different Console.WriteLine Changes depending on weather.

# PseudoCode

    if time 11.59 < 17.59
    Console.writeline("Good Morning.")

    If Temp 14 < wear clothes

    If Temp > 18 wear suncream

    if rain wear rain coat

    


    if time   (time > 0600) writeline God morgen
    if time   (time > 1000) writeline God formiddag
    else if   (time > 1400) writeline God ettermiddag
    else if   (time > 1800) writeline God kveld
    else      (time > 2300) writeline God natt


# finished product
  The finished product was fun. 
  It has a real life function for those with dementia or people with cognitive disabilites.

  First the clock will greet user with time of day.
  Then speaks time, give a weather report on temp and percipitation,
  depending on temp, it will output suggestions on what user should wear.

  Depending on how far out the user are in the stages of dementia, it can give
  as complex or basic information the caretakers see that the user needs.
  From where I have coded here, as I think will be the most useful early,
  to the absolutely most basic information as "God morgen" "God ettermiddag" "God kveld"
  Where the latter is useful to those with very advances stages of Alzheimers, and do not
  comprehend time in numbers as a healthy person does.

  I do think that this program has a practical use, and that I should make an effort to 
  program this on a micro computer as a Raspberry π or similar with motion sensor 
  to test the real world application of this.
  