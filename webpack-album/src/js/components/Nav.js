export default function Nav(){
    return `
    <div class="menu-wrap">
    <input type="checkbox" class="toggler">
    <div class="hamburger"><div></div></div>
    <div class="menu">
      <div>
        <div>
          <ul>
            <li><a href="#Home"><strong>Home</strong></a></li>
            <li><a href="#Artists"><strong>Artists</strong></a></li>
            <li><a href="#Albums"><strong>Albums</strong></a></li>
            <li><a href="#Songs"><strong>Songs</strong></a></li>
          </ul>
        </div>
      </div> 
    </div>
  </div>`
}