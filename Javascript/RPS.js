//Rock, Paper, Scissors


function playGame(playerChoice) {
  const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout,
  });

  rl.question("Enter your choice (rock, paper, or scissors): ", (playerChoice) => {
    rl.close();



//creates an array of choices
const choices = ["rock", "paper", "scissors"];

//Generates random choice for computer

const computerChoice = choices[Math.floor(Math.random() * choices.length)];

//player choice
const playerChoice = prompt("Enter your choice (rock, paper, or scissors:");//.toLowerCase();



//compare the choices and determine winner

if(playerChoice === computerChoice) {
  return "It's a tie!";
} else if(
  (playerChoice === "rock" && computerChoice === "scissors")  || 
  (playerChoice === "paper" && computerChoice === "rock") || 
  (playerChoice === "scissors" && computerChoice === "paper")
) {
  return "You win!";
} else {
  return "Computer wins!"
}


const result = playGame(playerChoice);
console.log(result);