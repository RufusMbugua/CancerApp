@Code
    ViewData("Title") = "Symptoms"
End Code

<h2>Symptoms</h2>
<form>
    <label>Name</label>
    <input type="text" name="name" placeholder="e.g Stomach ache" />
    <label>Details</label>
    <textarea name="details" placeholder="Write details here..."></textarea>
    <label>Disease</label>
    <select name="disease">
        <option>Please Select Disease</option>
    </select>
    <input type="submit" value="Submit" />
</form>