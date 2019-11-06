export default function Nav(){
    return `
    <div class="menu-wrap">
    <input type="checkbox" class="toggler">
    <div class="hamburger"><div></div></div>
    <div class="menu">
      <div>
        <div>
          <ul>
            <li><a id="Home"><strong>Home</strong></a></li>
            <li><a id="Artists"><strong>Artists</strong></a></li>
            <li><a id="Albums"><strong>Albums</strong></a></li>
            <li><a id="Songs"><strong>Songs</strong></a></li>
          </ul>
        </div>
      </div> 
    </div>
  </div>`
}