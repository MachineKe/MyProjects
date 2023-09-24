const readline = require('readline');

let playerWins = 0;
let computerWins = 0;

function playGame() {
  const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout,
  });

  rl.question('Enter your choice (rock, paper, or scissors): ', (playerChoice) => {
    rl.close();

    if (!playerChoice || !['rock', 'paper', 'scissors'].includes(playerChoice)) {
      console.log('Invalid choice. Please try again.');
      return;
    }

    const computerChoice = ['rock', 'paper', 'scissors'][Math.floor(Math.random() * 3)];
    
    let winner = determineWinner(playerChoice, computerChoice);

    if (winner === 'You win!') {
      playerWins++;
    } else if (winner === 'Computer wins!') {
      computerWins++;
    }

    console.log(winner);
  });
}

function determineWinner(playerChoice, computerChoice) {
  if (playerChoice === computerChoice) {
    return 'It\'s a tie!';
  } else if (
    (playerChoice === 'rock' && computerChoice === 'scissors') ||
    (playerChoice === 'paper' && computerChoice === 'rock') ||
    (playerChoice === 'scissors' && computerChoice === 'paper')
  ) {
    return 'You win!';
  } else {
    return 'Computer wins!';
  }
}

function playMultipleGames(numGames) {
  for (let i = 0; i < numGames; i++) {
    playGame();
  }

  // Reset the win counters.
  playerWins = 0;
  computerWins = 0;
}

playMultipleGames(10);

// Close the readline interface.
readline.close();

