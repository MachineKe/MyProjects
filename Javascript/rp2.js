const readline = require("readline");
// This line requires the `readline` module, which is used to read input from the user.

const computerChoice = ["rock", "paper", "scissors"][
  Math.floor(Math.random() * 3)
];
// This line generates a random computer choice from the array `["rock", "paper", "scissors"]`.

function playGame() {
  // This function defines a function called `playGame()`, which will be used to play the game.

  const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout,
  });
  // This line creates a new `readline` interface using the `process.stdin` and `process.stdout` streams. This will allow us to read input from the user and write output to the console.

  rl.question(
    "Enter your choice (rock, paper, or scissors): ",
    (playerChoice) => {
      // This line uses the `readline` interface to prompt the user for their choice and read their response. The user's response is stored in the variable `playerChoice`.

      rl.close();
      // This line closes the `readline` interface.

      if (
        !playerChoice ||
        !["rock", "paper", "scissors"].includes(playerChoice)
      ) {
        // This line checks if the user's choice is valid. If it is not, a message is logged to the console and the game ends.

        console.log("Invalid choice. Please try again.");
        return;
      }

      let response;
      // This line declares a variable called `response`. This variable will be used to store the outcome of the game.

      if (playerChoice === computerChoice) {
        // This line checks if the player's choice and the computer's choice are the same. If they are, the outcome is set to "It's a tie!".

        response = "It's a tie!";
      } else if (
        (playerChoice === "rock" && computerChoice === "scissors") ||
        (playerChoice === "paper" && computerChoice === "rock") ||
        (playerChoice === "scissors" && computerChoice === "paper")
      ) {
        // This line checks if the player's choice beats the computer's choice. If it does, the outcome is set to "You win!".

        response = "You win!";
      } else {
        // This line checks if the computer's choice beats the player's choice. If it does, the outcome is set to "Computer wins!".

        response = "Computer wins!";
      }

      console.log(`Computer choice is ${computerChoice}`);
      // This line logs the computer's choice to the console.

      console.log(response);
      // This line logs the outcome of the game to the console.
    }
  );
}

playGame();
// This line calls the `playGame()` function to start the game.
