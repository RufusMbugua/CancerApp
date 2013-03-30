@Code
    ViewData("Title") = "Prevention"
End Code

<h2>Prevention</h2>
<form>
    <label>Name</label>
    <input type="text" name="name" placeholder="e.g Eat a balanced diet"/>
    <label>Details</label>
    <textarea name="details" placeholder="Write details here..."></textarea>
    <label>Disease</label>
    <select name="disease">
        <option>Please Select Disease</option>
    </select>
    <label>Image</label>
    <input type="file" name="image"/>
    <label>Category</label>
    <select name="category">
        <option>Please Choose Category</option>
    </select>
    <input type="submit" value="Submit" />
</form>
