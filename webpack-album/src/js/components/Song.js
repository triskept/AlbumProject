export default function Song(songs) {
    return `
    <section id="songgrid">
    <ul> 
    ${songs
      .map(songEdit => {
        return `
             <li>
                <h3>${songEdit.title}</h3>
                <h4>Album: ${songEdit.albumTitle}</h4>
                <h5>Duration: ${songEdit.duration}</h5>
                <p><input class="song_id" type="hidden" value="${songEdit.id}"></p>
                <button class="edit-song_submit">Edit</button>
                <button class="delete-song_submit">Delete</button>
              </li>
        `;
      })
      .join("")}
 </ul>
</section>
<section class='add-song'>
      <select class="add-song_album" name="Album">
      <option value="1">Man On The Moon</option>
      <option value="2">Man On The Moon 2</option>
      <option value="3">Indicud</option>
      <option value="4">Satellite Flight: The Journey to Mother Moon</option>
      <option value="5">Speedin' Bullet 2 Heaven</option>
      <option value="6">Passion, Pain & Demon Slayin</option>
      <option value="7">Night Visions</option>
      <option value="8">Smoke + Mirrors</option>
      <option value="9">Evolve</option>
      <option value="10">Origins</option>
      <option value="11">The Division Bell</option>
      <option value="12">Adam Heart Mother</option>
      <option value="13>The Final Cut</option>
      <option value="14">The Dark Side of the Moon</option>
      <option value="15">Songs in A Minor</option>
      <option value="16">Diary of Alicia Keys</option>
      <option value="17">As I Am</option>
      <option value="18">The Element of Freedom</option>
      <option value="19">Girl on Fire</option>
      <option value="20">Here</option>
      </select>
    <input class='add-song_songTitle' type='text' placeholder='Add A New Song!'>
    <input class='add-song_songDuration' type='text' placeholder='Add Song Duration 0:00!'>
    <button class='add-song_submit'>Submit</button>
</section>
    `;
}