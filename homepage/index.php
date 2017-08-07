<?php include ('header.php'); ?>
  <?php    
    include ('dbconnect.php');

    $sqlvoter = "SELECT * FROM voterdb WHERE id = ". mysqli_real_escape_string($conn,$_GET['id']);
    $resultvoter = mysqli_query($conn,$sqlvoter);

    if(!$resultvoter){
      echo "<h3 class='text-center'>The user with id = '" . mysqli_real_escape_string($conn,$_GET['id']) . "' does not exist<h3>" . mysqli_error($conn);
    } else {
      ?>
    <div class="container">
      <div class="row">
        <div class="page-header text-center">
          <h1>
          <?php $row1 = mysqli_fetch_assoc($resultvoter);
            echo "Welcome to voting system of <strong>" . $row1['constituency'] . "</strong> Constituency of Bhutan";
          ?>
          </h1>
        </div>
        <h3 class="text-center">Vote from one of the candidate below:</h3>
        <?php
        $number = 1;
        $sqlcandidate = "SELECT candidatedb.id, candidatedb.photo, candidatedb.name FROM candidatedb INNER JOIN voterdb WHERE candidatedb.constituency = voterdb.constituency ORDER BY name";
        $resultcandidate = mysqli_query($conn,$sqlcandidate);
        if (!$resultcandidate) {
        	echo "My SQL Error" . mysqli_error($conn);
        	exit();
        } else {
        	while ($row2 = mysqli_fetch_assoc($resultcandidate)) {
				echo "<div class='col-md-1'>". $number .".</div>";
				echo "<div class='col-md-5'>". $row2['name'] ."</div>";
				echo "<div class='col-md-3'><img class='img-responsive' src='data:image/jpeg;base64,". base64_encode($row2['photo']) ."'/></div>";
				echo "<div class='col-md-3'><a href='poll.php?id=". $row2['id'] ."' class='btn btn-success btn-default btn-block' role='button'>VOTE!</a>";
				$number = $number + 1;
				}
        	}
        ?>
      </div>
    </div>
      <?php
        }
  ?>
<?php include ('footer.php'); ?>