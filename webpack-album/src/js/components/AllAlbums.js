import Artist from "./Artist"

export default function AllAlbum(allalbums) {
    return `<section id="albumgrid">    
    <ul> 
        ${allalbums
          .map(albumEdit => {
            return `
                 <li id="album">
                    <img src=${albumEdit.image}></img>
                    <h3>${albumEdit.title}</h3>
                    <h5>Label: ${albumEdit.label}</h5>
                    <p><input class="album_id" type="hidden" value="${Artist.id}"></p>               
                    <p><input class="album_id" type="hidden" value="${albumEdit.id}"></p>
                    <button class="edit-album_submit">Edit</button>
                    <button class="delete-album_submit">Delete</button>
                 </li>
            `;
          })
          .join("")}
     </ul>
     </section>
    `;
}
