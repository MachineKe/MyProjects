//creates constant variable kelvin and sets its value
const kelvin = 293;

//creates varible celcius and computes its value from that of kelvin
let celsius = kelvin - 273;

//creates variable farhenheight and computes it value from celcius
let farhenheight = celsius * (9/5) + 32;

//rounds off value of farhenheight
farhenheight = Math.floor(farhenheight);

console.log(`The temperature is ${farhenheight} degrees Farhenheight`);