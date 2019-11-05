export default function HomeGrid(){
    return `
    <section id="grid">
        <div id="artists">
            <i class="fas fa-guitar fa-5x"></i>
            <h3>Artists</h3>
        </div>
        <div id="albums">
        <i class="fas fa-record-vinyl fa-5x"></i>
            <h3>Albums</h3>
        </div>
        <div id="songs">
            <i class="fas fa-music fa-5x"></i>
            <h3>Songs</h3>
        </div>
    </section>

    <section id="grid2">
        <div id="artistbutton">
            <a id="artistbrowse">Browse</a>
        </div>
        <div id="albumbutton">
            <a id="albumbrowse">Browse</a>
        </div>
        <div id="songbutton">
            <a id="songbrowse">Browse</a>
        </div>
    </section>

    <section id="featured">
        <div id="featuredimg">
            <h2>Featured Album</h2>
            <img src="/images/dark-side-of-moon.jpg"></img>
        </div>
        <div id="description">
            <h3>Dark Side Of The Moon</h3>
            <h4><em>Pink Floyd</em></h4>
        </div>
    </section>
`
}