const readline = require("readline");
const computerChoice = ["rock", "paper", "scissors"][
  Math.floor(Math.random() * 3)
];

function playGame() {
  const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout,
  });

  rl.question(
    "Enter your choice (rock, paper, or scissors): ",
    (playerChoice) => {
      rl.close();

      if (
        !playerChoice ||
        !["rock", "paper", "scissors"].includes(playerChoice)
      ) {
        console.log("Invalid choice. Please try again.");
        return;
      }

      let response;
      if (playerChoice === computerChoice) {
        response = "It's a tie!";
      } else if (
        (playerChoice === "rock" && computerChoice === "scissors") ||
        (playerChoice === "paper" && computerChoice === "rock") ||
        (playerChoice === "scissors" && computerChoice === "paper")
      ) {
        response = "You win!";
      } else {
        response = "Computer wins!";
      }

      console.log(`Computer choice is ${computerChoice}`);
      console.log(response);
    }
  );
}

playGame();
