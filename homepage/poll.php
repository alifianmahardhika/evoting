<?php include ('header.php'); ?>
<div class="container">
	<div class="row">
			<?php
				include ('dbconnect.php');

				$_SESSION['id'] = mysqli_real_escape_string($conn,$_GET['id']);
				$sqlPoll = "UPDATE candidatedb SET voteCount = voteCount+1 WHERE candidatedb.id =". $_SESSION['id'];

				$resultPollQuery = mysqli_query($conn,$sqlPoll);

				if (!$resultPollQuery) {
					echo "<div class='text-center'><h3>Failed to submit vote, try to submit again</h3><div></br>";
					echo "<a href='poll.php?id=". $_SESSION['id'] ."' class='btn btn-default'>Reload</a>";
				} else {
					echo "<div class='text-center'><h3><strong>Vote submitted</strong><small>Thank you for your vote!</small></h3></div></br>";
					echo "<div class='text-center'><h5>Back to Bhutan Election <a href='index.php'>Homepage</a>";
				}
			?>
	</div>
</div>

<?php include ('footer.php'); ?>