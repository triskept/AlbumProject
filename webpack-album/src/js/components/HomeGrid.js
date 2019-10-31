export default function HomeGrid(){
    return `
    <section id="grid">
        <div id="artists">
            <i class="fas fa-guitar fa-5x"></i>
            <h3>Artists</h3>
            <a id="artistbrowse" href="">Browse</a>
        </div>
        <div id="albums">
        <i class="fas fa-record-vinyl fa-5x"></i>
            <h3>Albums</h3>
            <a id="albumbrowse" href="">Browse</a>
        </div>
        <div id="songs">
            <i class="fas fa-music fa-5x"></i>
            <h3>Songs</h3>
            <a id="songbrowse" href="">Browse</a>
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