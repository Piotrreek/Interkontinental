import {showStatistics} from './api.js'
import {statistics, loadMoreStatisticsBtn, loadAllStatisticsBtn} from './elements.js'
import {fields, numberOfGames} from './index.js'
let statisticsGameCounter = 4

export const showDefaultStatistics = async () => {
    statisticsGameCounter = 4
    const data = await showStatistics(statisticsGameCounter - 4, statisticsGameCounter - 2)
    data.map((game) => loadStatisticsSingleGame(game))
}

export const loadStatisticsForMoreGames = async () => {
    const data = await showStatistics(statisticsGameCounter - 2, statisticsGameCounter)
    statisticsGameCounter += 2
    data.map((game) => loadStatisticsSingleGame(game))
}

export const loadAllGames = async () => {
    const data = await showStatistics(statisticsGameCounter - 2, numberOfGames)
    loadMoreStatisticsBtn.classList.add('hide')
    loadAllStatisticsBtn.classList.add('hide')
    data.map((game) => loadStatisticsSingleGame(game))
}

const loadStatisticsSingleGame = (game) => {
    const gameSection = document.createElement('section')
        gameSection.classList.add('game')
        const h2Time = document.createElement('h2')
        h2Time.classList.add('statistics__time')
        h2Time.innerText = 'Gra z dnia: ' + game.start + ' - ' + game.end
        statistics.appendChild(h2Time)
        fields.map((type) => {
            const h2 = document.createElement('h2')
            h2.classList.add('statistics__country-name')
            h2.innerText = type[0].type
            gameSection.appendChild(h2)
            const div = document.createElement('div')
            div.classList.add('statistics__country')
            type.map((field) => {
                const counter = game.counters.find(({fieldId}) => fieldId === field.id)
                const divField = document.createElement('div')
                divField.classList.add('statistics__field')
                divField.innerHTML = field.name + "<br/>Ilość: " + counter.count
                div.appendChild(divField)
            })
            gameSection.appendChild(div)
        })
        gameSection.classList.add('hide')
        statistics.appendChild(gameSection)
        const showGameDiv = document.createElement('div')
        showGameDiv.classList.add('show-more-btn')
        const showGameBtn = document.createElement('button')
        showGameBtn.innerHTML = 'Rozwiń<br/>' + '<i class="fa-sharp fa-solid fa-arrow-down"></i>'
        showGameBtn.addEventListener('click', () => {
            gameSection.classList.toggle('hide')
            if(!gameSection.classList.contains('hide'))
                showGameBtn.innerHTML = 'Zwiń<br/>' + '<i class="fa-sharp fa-solid fa-arrow-up"></i>'
            else
                showGameBtn.innerHTML = 'Rozwiń<br/>' + '<i class="fa-sharp fa-solid fa-arrow-down"></i>'
        })
        showGameDiv.appendChild(showGameBtn)
        statistics.appendChild(showGameDiv)
}