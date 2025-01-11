// Event listener for like buttons
document.querySelectorAll('[id^="like-btn-"]').forEach(button => {
    button.addEventListener('click', async function () {
        const mediaId = this.getAttribute('data-media-id');
        await handleReaction(mediaId, true); // true for "like"
    });
});

// Event listener for dislike buttons
document.querySelectorAll('[id^="dislike-btn-"]').forEach(button => {
    button.addEventListener('click', async function () {
        const mediaId = this.getAttribute('data-media-id');
        await handleReaction(mediaId, false); // false for "dislike"
    });
});

// Handle reaction (like/dislike)
async function handleReaction(mediaId, isLike) {
    try {
        const response = await fetch('/Rating/AddReaction', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json',
            },
            body: JSON.stringify({ mediaId, isLike })
        });

        if (response.ok) {
            // Update both counts (like and dislike) to ensure consistent UI
            fetchLikeCount(mediaId);
            fetchDislikeCount(mediaId);
        } else {
            console.error('Failed to update reaction.');
        }
    } catch (error) {
        console.error('Error:', error);
    }
}

// Fetch like count
async function fetchLikeCount(mediaId) {
    try {
        const response = await fetch(`/Rating/GetLikeCount?mediaId=${mediaId}`);
        if (response.ok) {
            const data = await response.json();
            const likeCountSpan = document.getElementById(`like-count-${mediaId}`);
            if (likeCountSpan) {
                likeCountSpan.textContent = data.likeCount;
            }
        } else {
            console.error('Failed to fetch like count:', response.statusText);
        }
    } catch (error) {
        console.error('Error while fetching like count:', error);
    }
}

// Fetch dislike count
async function fetchDislikeCount(mediaId) {
    try {
        const response = await fetch(`/Rating/GetDislikeCount?mediaId=${mediaId}`);
        if (response.ok) {
            const data = await response.json();
            const dislikeCountSpan = document.getElementById(`dislike-count-${mediaId}`);
            if (dislikeCountSpan) {
                dislikeCountSpan.textContent = data.dislikeCount;
            }
        } else {
            console.error('Failed to fetch dislike count:', response.statusText);
        }
    } catch (error) {
        console.error('Error while fetching dislike count:', error);
    }
}

// Fetch initial counts on page load
document.addEventListener('DOMContentLoaded', () => {
    document.querySelectorAll('[data-media-id]').forEach(button => {
        const mediaId = button.getAttribute('data-media-id');
        fetchLikeCount(mediaId);
        fetchDislikeCount(mediaId);
    });
});
